﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories
        {
            get; 
        }
    }
}
