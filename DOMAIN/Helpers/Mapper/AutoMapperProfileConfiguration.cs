
using AutoMapper;
using Domain.DTOs.Administrators;
using Domain.DTOs.Comments;
using Domain.DTOs.Customers;
using Domain.DTOs.Items;
using Domain.DTOs.Orders;
using Domain.Entities.Adminstrators;
using Domain.Entities.Comments;
using Domain.Entities.Customers;
using Domain.Entities.Items;
using Domain.Entities.Orders;

namespace Domain.Helpers.Mapper;

public class AutoMapperProfileConfiguration : Profile
{

	public AutoMapperProfileConfiguration()
	{

        // createMap<source, destination>
        CreateMap<AdministratorDTO, Administrator>()
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
            .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore());

        CreateMap<Administrator, AdministratorDTO>()
            .ForMember(dest => dest.Password, opt => opt.Ignore());

        // ----
        CreateMap<ChatDTO, Chat>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID))
            .ForMember(dest => dest.AdministratorID, opt => opt.MapFrom(src => src.AdministratorDTO.ID));

        CreateMap<Chat, ChatDTO>();

        // ----
        CreateMap<CommentDTO, Comment>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID))
            .ForMember(dest => dest.ItemID, opt => opt.MapFrom(src => src.ItemDTO.ID));

        CreateMap<Comment, CommentDTO>();

        // ----
        CreateMap<AddressDTO, Address>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID));

        CreateMap<Address, AddressDTO>();

        // ----
        CreateMap<AvatarDTO, Avatar>();

        CreateMap<Avatar, AvatarDTO>();

        // ----
        CreateMap<CreditCardDTO, CreditCard>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID));

        CreateMap<CreditCard, CreditCardDTO>();

        // ----
        CreateMap<CustomerDTO, Customer>()
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
            .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore());

        CreateMap<Customer, CustomerDTO>()
            .ForMember(dest => dest.Password, opt => opt.Ignore());

        // ----
        CreateMap<PhoneDTO, Phone>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID));

        CreateMap<Phone, PhoneDTO>();

        // ----
        CreateMap<BrandDTO, Brand>().ReverseMap();

        // ----
        CreateMap<CategoryDTO, Category>().ReverseMap();

        // ----
        CreateMap<ClotheSizeDTO, ClotheSize>().ReverseMap();

        // ----
        CreateMap<ColorDTO, Color>().ReverseMap();

        // ----
        CreateMap<ImageDTO, Image>().ReverseMap();

        // ----
        CreateMap<ItemDTO, Item>()
            .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.CategoryDTO.ID))
            .ForMember(dest => dest.BrandID, opt => opt.MapFrom(src => src.BrandDTO.ID));

        CreateMap<Subitem, SubitemDTO>();

        // ----
        CreateMap<SubitemDTO, Subitem>()
            .ForMember(dest => dest.ItemID, opt => opt.MapFrom(src => src.ItemDTO.ID))
            .ForMember(dest => dest.ColorID, opt => opt.MapFrom(src => src.ColorDTO.ID));

        CreateMap<Subitem, SubitemDTO>();

        // ----
        CreateMap<TechCapacityDTO, TechCapacity>().ReverseMap();

        // ----
        CreateMap<TechSizeDTO, TechSize>().ReverseMap();

        // ----
        CreateMap<OrderCreditCardDTO, OrderCreditCard>().ReverseMap();

        // ----
        CreateMap<TechSizeDTO, TechSize>().ReverseMap();

        // ----
        CreateMap<OrderDTO, Order>()
            .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerDTO.ID))
            .ForMember(dest => dest.ShipmentMethodID, opt => opt.MapFrom(src => src.ShipmentMethodDTO.ID))
            .ForMember(dest => dest.OrderCreditCardID, opt => opt.MapFrom(src => src.OrderCreditCardDTO.ID));

        CreateMap<Order, OrderDTO>();

        // ----
        CreateMap<ReturnDTO, Return>()
            .ForMember(dest => dest.PurchaseID, opt => opt.MapFrom(src => src.PurchaseDTO.ID));

        CreateMap<Return, ReturnDTO>();

        // ----
        CreateMap<ShipmentMethodDTO, ShipmentMethod>().ReverseMap();

        // ----
        CreateMap<PurchaseDTO, Purchase>()
            .ForMember(dest => dest.OrderID, opt => opt.MapFrom(src => src.OrderDTO.ID))
            .ForMember(dest => dest.SubitemID, opt => opt.MapFrom(src => src.SubitemDTO.ID));

        CreateMap<Purchase, PurchaseDTO>();

    }

}