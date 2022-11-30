using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDataBase = new List<PizzasModel>
        {
            new PizzasModel() {ImageTitle="Margerita",PizzaName="Margerita",BasePrice = 10,TomatoSauce = true,Cheese = true,FinalPirce = 14},

			new PizzasModel() {ImageTitle="Bolognese",PizzaName="Bolognese",BasePrice = 15,TomatoSauce = true,Cheese = true,Ham = true, FinalPirce = 20},

			new PizzasModel() {ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice = 16,TomatoSauce = true,Cheese = true,Pork = true, FinalPirce = 22},
		};
        public void OnGet()
        {
        }
    }
}
