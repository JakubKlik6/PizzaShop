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
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
			if (Pizza.Cheese) PizzaPrice += 3;
			if (Pizza.Pepperoni) PizzaPrice += 3;
			if (Pizza.Ham) PizzaPrice += 2;
			if (Pizza.Pineapple) PizzaPrice += 10;
			if (Pizza.Beef) PizzaPrice += 5;
			if (Pizza.Pork) PizzaPrice += 6;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice });
		}
    }
}
