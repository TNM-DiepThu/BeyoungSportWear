using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.Image
{
    public class ImageCreateVM
    {
        public string CreateBy { get; set; } = null!;
        public Guid? IDProductDetails { get; set; }
        public Guid? IDOptions { get; set; }
        public IFormFile Path { get; set; } = null!;
        public int Status { get; set; }
    }
}
