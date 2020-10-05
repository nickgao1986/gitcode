using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XieChengAPI.Helper;
using XieChengAPI.Models;

namespace XieChengAPI.Service
{
    public interface ITouristRouteRepository
    {
        Task<PaginationList<TouristRoute>> GetTouristRoutesAsync(
           string keyword, string ratingOperator, int? ratingValue
           , int pageSize, int pageNumber, string orderBy);
        Task<TouristRoute> GetTouristRouteAsync(Guid touristRouteId);


        TouristRoute GetTouristRoute(Guid touristRouteId);
        bool TouristRouteExists(Guid touristRouteId);
        IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId);
        TouristRoutePicture GetPicture(int pictureId);
        IEnumerable<TouristRoute> GetTouristRoutesByIDList(IEnumerable<Guid> ids);
        void AddTouristRoute(TouristRoute touristRoute);
        void AddTouristRoutePicture(Guid touristRouteId, TouristRoutePicture touristRoutePicture);
        void DeleteTouristRoute(TouristRoute touristRoute);
        void DeleteTouristRoutes(IEnumerable<TouristRoute> touristRoutes);
        void DeleteTouristRoutePicture(TouristRoutePicture picture);

        public Task CreateShoppingCart(ShoppingCart shoppingCart);
        Task<ShoppingCart> GetShoppingCartByUserId(string userId);
        bool Save();
        public Task<bool> SaveAsync();
        Task<LineItem> GetShoppingCartItemByItemId(int lineItemId);
        void DeleteShoppingCartItem(LineItem lineItem);
        Task AddShoppingCartItem(LineItem lineItem);

        Task<IEnumerable<LineItem>> GeshoppingCartsByIdListAsync(IEnumerable<int> ids);
        void DeleteShoppingCartItems(IEnumerable<LineItem> lineItems);
        Task<Order> GetOrderById(Guid orderId);
        Task AddOrderAsync(Order order);

        Task<PaginationList<Order>> GetOrdersByUserId(string userId, int pageSize, int pageNumber);

    


    }
}
