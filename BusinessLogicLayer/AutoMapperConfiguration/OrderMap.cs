using AutoMapper;
using BusinessLogicLayer.Viewmodels.Order;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace BusinessLogicLayer.AutoMapperConfiguration
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<OrderCreateVM, Order>()
                //.ForMember(dest => dest.IDUser, opt => opt.MapFrom(src => src.IDUser))
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())  // Sẽ được set bên ngoài ánh xạ
                .ForMember(dest => dest.OrderStatus, opt => opt.MapFrom(src => OrderStatus.Pending))
                .ForMember(dest => dest.ShipDate, opt => opt.MapFrom(src => src.ShipDate))
                .ForMember(dest => dest.ShippingAddress, opt => opt.MapFrom(src => src.ShippingAddress))
                .ForMember(dest => dest.TrackingCheck, opt => opt.MapFrom(src => src.TrackingCheck))
                .ForMember(dest => dest.PaymentMethods, opt => opt.MapFrom(src => src.PaymentMethods))
                .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(src => src.PaymentStatus))
                .ForMember(dest => dest.ShippingMethods, opt => opt.MapFrom(src => src.ShippingMethods))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => 1))
                .AfterMap((src, dest) =>
                {
                    dest.CreateDate = DateTime.UtcNow;
                });

            CreateMap<Order, OrderVM>()
                .ReverseMap();

        }
    }
}
