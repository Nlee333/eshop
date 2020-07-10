﻿using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Core.Models
{
    public class BasketItem :BaseEntity
    {
        public string BasketId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}