﻿using ShoppingBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.DataAccessLayer.Infrastructure.IRepository
{
    public interface IContactRepository : IRepository<Contact>
    {
        void Update(Contact contact);
    }
}
