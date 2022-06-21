﻿using FreeCourse.Shared.Dtos;
using FreeCourseServices.Basket.Dtos;
using System.Threading.Tasks;

namespace FreeCourseServices.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string userId);
    }
}