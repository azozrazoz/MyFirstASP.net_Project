﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили",desc = "Современный вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc = "Автомобили с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
