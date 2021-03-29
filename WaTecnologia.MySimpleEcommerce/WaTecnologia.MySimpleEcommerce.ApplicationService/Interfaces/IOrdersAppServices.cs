﻿using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces
{
    public interface IOrdersAppServices : IBaseAppServices<Order, OrderViewModel>
    {
    }
}