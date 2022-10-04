using JoePizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoePizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> mockPizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageUrl="Chicken_Dominator", PizzaName="Chicken Dominator", FinalPrice=250,OrderId=0001},
            new PizzasModel(){ImageUrl="Chicken_Fiesta", PizzaName="Chicken Fiesta", FinalPrice=200,OrderId=0002},
            new PizzasModel(){ImageUrl="NonVeg_Supreme", PizzaName="Non-Veg Supreme", FinalPrice=230,OrderId=0003 },
            new PizzasModel(){ImageUrl="Chicken_Sausage", PizzaName="Chicken Sausage", FinalPrice=280,OrderId=0004 },
            new PizzasModel(){ImageUrl="Farmhouse", PizzaName="Farmhouse", FinalPrice=270,OrderId=0005 },
            new PizzasModel(){ImageUrl="Indi_Tandoori_Paneer", PizzaName="Indi Tandoori Paneer", FinalPrice=330,OrderId=0006 },
            new PizzasModel(){ImageUrl="Mexican_Green_Wave", PizzaName="Mexican Green Wave", FinalPrice=260,OrderId=0007 },
            new PizzasModel(){ImageUrl="Peppy_Paneer", PizzaName="Peppy Paneer", FinalPrice=289,OrderId=0008 },
        };
        public void OnGet()
        {
        }
    }
}
