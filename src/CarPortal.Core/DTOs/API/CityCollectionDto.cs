using CarPortal.Core.DTOs.Offer.DropDownModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.API
{
    public class CityCollectionDto
    {
        public List<CityDropDown> CityCollection { get; set; } = new List<CityDropDown>();
    }
}
