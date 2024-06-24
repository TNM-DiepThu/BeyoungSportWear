using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BusinessLogicLayer.Viewmodels.Address;
using static DataAccessLayer.Entity.Base.EnumBase;
namespace BusinessLogicLayer.Services.Implements
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly MailSettings _mailSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public ApplicationUserService(ApplicationDBContext ApplicationDBContext,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            IOptions<MailSettings> mailSettings,
            UserManager<ApplicationUser> userManager,
                           IHttpContextAccessor httpContextAccessor,
                           IConfiguration IConfiguration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = ApplicationDBContext;
            _mailSettings = mailSettings.Value;
            _httpContextAccessor = httpContextAccessor;
            _configuration = IConfiguration;

        }
        private async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["JWT:DurationInMinutes"])),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha512Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private async Task SaveUserLoginAsync(ApplicationUser user, string loginProvider, string providerKey, string displayName)
        {
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey, displayName);
            await _userManager.AddLoginAsync(user, userLoginInfo);
        }
        private async Task SaveUserClaimsAsync(ApplicationUser user, List<Claim> claims)
        {
            foreach (var claim in claims)
            {
                await _userManager.AddClaimAsync(user, claim);
            }
        }
        private async Task SaveJwtTokenToUserAsync(ApplicationUser user, string token)
        {
            await _userManager.SetAuthenticationTokenAsync(user, _configuration["JWT:Issuer"], "JWT", token);
        }
        private async Task<Response> SendConfirmationEmailAsync(string email, Uri callbackUri)
        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName),
                    Subject = "Xác nhận địa chỉ email",
                    Body = $"Vui lòng xác nhận địa chỉ email của bạn bằng cách nhấp vào <a href='{callbackUri}'>đây</a>.",
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(email));

                using (SmtpClient smtp = new SmtpClient(_mailSettings.Host, _mailSettings.Port))
                {
                    smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
                    smtp.EnableSsl = true;

                    await smtp.SendMailAsync(mail);
                }

                return new Response
                {
                    IsSuccess = true,
                    StatusCode = 200,
                    Message = "Email xác nhận đã được gửi."
                };
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 500,
                    Message = $"Lỗi khi gửi email xác nhận: {ex.Message}"
                };
            }
        }
        public async Task<List<UserDataVM>> GetAllActiveInformationAsync()
        {
            var users = await _dbContext.ApplicationUser
                .Where(c => c.Status == 1)
                            .ToListAsync();

            var userDataList = users.Select(u => new UserDataVM
            {
                ID = u.Id,
                Username = u.UserName,
                Email = u.Email,
                FirstAndLastName = u.FirstAndLastName,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status,
            }).ToList();

            return userDataList;
        }
        public async Task<List<UserDataVM>> GetAllInformationAsync()
        {
            var users = await _dbContext.ApplicationUser
                .ToListAsync();

            var userDataList = users.Select(u => new UserDataVM
            {
                ID = u.Id,
                Username = u.UserName,
                Email = u.Email,
                FirstAndLastName = u.FirstAndLastName,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status,

            }).ToList();

            return userDataList;
        }
        public async Task<UserDataVM> GetInformationByID(string ID)
        {
            var user = await _dbContext.ApplicationUser
                .Where(u => u.Id == ID)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return null;
            }

            var userVM = new UserDataVM
            {
                ID = user.Id,
                FirstAndLastName = user.FirstAndLastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Username = user.UserName,
                Status = user.Status,
            };
            return userVM;
        }
        public async Task<Response> Login(UserLoginModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.UserName) || string.IsNullOrWhiteSpace(model.PassWord))
            {
                return new Response { IsSuccess = false, StatusCode = 400, Message = "Username and password must be provided." };
            }

            try
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null || !(await _userManager.CheckPasswordAsync(user, model.PassWord)))
                {
                    return new Response { IsSuccess = false, StatusCode = 401, Message = "Invalid credentials." };
                }

                await _userManager.RemoveAuthenticationTokenAsync(user, _configuration["JWT:Issuer"], "JWT");
                var logins = await _userManager.GetLoginsAsync(user);
                foreach (var login in logins)
                {
                    await _userManager.RemoveLoginAsync(user, login.LoginProvider, login.ProviderKey);
                }
                var claims = await _userManager.GetClaimsAsync(user);
                foreach (var claim in claims)
                {
                    await _userManager.RemoveClaimAsync(user, claim);
                }

                var tokenString = await GenerateJwtToken(user);

                await SaveJwtTokenToUserAsync(user, tokenString);

                await SaveUserLoginAsync(user, "XXXXXXXXXX", "ProviderKey", "UserDisplayName");

                var userClaims = new List<Claim>();
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var role in userRoles)
                {
                    userClaims.Add(new Claim(ClaimTypes.Role, role));
                }
                await SaveUserClaimsAsync(user, userClaims);

                var roles = await _userManager.GetRolesAsync(user);

                return new Response
                {
                    IsSuccess = true,
                    StatusCode = 200,
                    Message = "Authentication successful.",
                    Token = tokenString,
                    Roles = roles.ToList()
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in Login: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return new Response { IsSuccess = false, StatusCode = 500, Message = "Internal server error." };
            }
        }
        public async Task<Response> RegisterAsync(RegisterUser registerUser, string role)
        {
            try
            {
                var existingUser = await _userManager.FindByEmailAsync(registerUser.Email);
                if (existingUser != null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        StatusCode = 400,
                        Message = "This email is already in use."
                    };
                }

                existingUser = await _userManager.FindByNameAsync(registerUser.Username);
                if (existingUser != null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        StatusCode = 400,
                        Message = "This username is already taken."
                    };
                }

                if (registerUser.Password != registerUser.ConfirmPassword)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        StatusCode = 400,
                        Message = "The password and confirmation password do not match."
                    };
                }

                var newUser = new ApplicationUser
                {
                    UserName = registerUser.Username,
                    Email = registerUser.Email,
                    FirstAndLastName = registerUser.FirstAndLastName,
                    PhoneNumber = registerUser.PhoneNumber,
                    Status = 1,
                    EmailConfirmed = false
                };
                var result = await _userManager.CreateAsync(newUser, registerUser.Password);
                if(result.Succeeded)
                {
                    var cart = new Cart
                    {
                        ID = Guid.NewGuid(),
                        IDUser = newUser.Id,
                        Status = 1,
                        CreateBy = newUser.Id,
                        CreateDate = DateTime.Now,
                    };
                    await _dbContext.Cart.AddRangeAsync(cart);
                    var aName = registerUser.AddressCreateVM.FirstOrDefault()?.Name;
                    var addressType = registerUser.AddressCreateVM.FirstOrDefault()?.AddressType;
                    var parentID = registerUser.AddressCreateVM.FirstOrDefault()?.ParentID;
                    var address = new Address
                    {
                        ID = Guid.NewGuid(),
                        IDUser = newUser.Id,
                        Name = aName,
                        AdressType = addressType.Value,
                        ParentID = parentID,
                    };
                    await _dbContext.Address.AddRangeAsync(address);

                }
                await _dbContext.SaveChangesAsync();

                if (await _roleManager.RoleExistsAsync(role))
                {
                    await _userManager.AddToRoleAsync(newUser, role);

                    var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

                    var host = _httpContextAccessor.HttpContext.Request.Host;

                    var callbackUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{host}/Account/ConfirmEmail?userId={newUser.Id}&code={emailConfirmationToken}";

                    var callbackUri = new Uri(callbackUrl);
                    await SendConfirmationEmailAsync(newUser.Email, callbackUri);

                    return new Response
                    {
                        IsSuccess = true,
                        StatusCode = 201,
                        Message = "Register successfully! Please check your email for confirmation."
                    };
                }
                else
                {
                    return new Response
                    {
                        IsSuccess = false,
                        StatusCode = 500,
                        Message = "Register failed, something went wrong!"
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 500,
                    Message = "An error occurred while saving the entity changes. See the inner exception for details.",

                };
            }
        }
        public async Task<bool> RemoveAsync(string ID, string IDUserDelete)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var obj = await _dbContext.ApplicationUser.FirstOrDefaultAsync(c => c.Id == ID);

                    if (obj != null)
                    {
                        obj.Status = 0;
                        _dbContext.ApplicationUser.Attach(obj);
                        await _dbContext.SaveChangesAsync();


                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<List<Address>> GetAddressesByTypeAsync(AdressType type)
        {
            return await _dbContext.Address.Where(a => a.AdressType == type).ToListAsync();
        }
    }
}
