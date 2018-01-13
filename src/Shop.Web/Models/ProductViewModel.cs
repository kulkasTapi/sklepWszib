using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class ProductViewModel
    {
        //utwóz nowy produkt bazując na dropdawn pod 
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name was not provided.")]
        [StringLength(100, MinimumLength = 3)]//opcjonalnie jest ilość minimalna
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }


        //lista która służy do pobierania kategorize słownika SelectListItem

    }
}
