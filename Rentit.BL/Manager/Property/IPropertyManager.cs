﻿using Rentit.BL.Dtos;
using Rentit.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentit.BL
{
    public interface IPropertyManager
    {
        IEnumerable<ListPropertyReadDto> GetAll();
        ListPropertyReadDto? GetById(int id);
        int Add(int requestID);
        bool Update (PropertyUpdateDto propertyUpdate);
        bool Delete(int id);
        PropertyReadDetailsDto? GetPropertyDetails (int id);

         

    }
}
