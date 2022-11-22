using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        //Bind PizzaModel to CustomPizzaModel
        [BindProperty]
        //This will allow us to create pizza in CustomPizza.html 
        public PizzasModel Pizza { get; set; }

        public void OnGet()
        {
        }
    }
}
