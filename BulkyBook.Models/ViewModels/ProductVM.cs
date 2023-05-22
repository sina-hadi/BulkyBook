using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBook.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        // Using ViewBag
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        // Using ViewData
        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

    }
}
