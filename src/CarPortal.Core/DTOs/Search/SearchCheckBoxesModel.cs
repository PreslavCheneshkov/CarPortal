using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Search
{
    public class SearchCheckBoxesModel
    {
        public List<SelectListItem> Extras { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Colors { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> FuelTypes { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TransmissionTypes { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Regions { get; set; } = new List<SelectListItem>();
    }
}
