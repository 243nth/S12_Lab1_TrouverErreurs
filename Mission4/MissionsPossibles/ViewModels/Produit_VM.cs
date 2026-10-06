using Microsoft.AspNetCore.Mvc.Rendering;
using Mission.Models;

namespace Mission.ViewModels
{
    public class Produit_VM
    {
        public Produit Produit { get; set; }
        public IEnumerable<SelectListItem> CategorieList { get; set; }

        public int CategorieId { get; set;}


    }
}
