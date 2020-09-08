using CoffeeShopService.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopRepository
{
    public class Repository
    {
        public List<Coffee> Coffees { get; set; }
        public async Task<List<Coffee>> CreateCoffees() 
        {
            foreach (string coffees in File.ReadAllLines("C:\\skole\\eux\\H2\\WPF\\CoffeeShop\\starbucks coffee menu.txt"))
            {
                int id = 1;
                Coffees.Add(new Coffee { CoffeeName = coffees, CoffeeId = id, AmountInStock = 10, FirstAddedToStockDate = DateTime.Now, InStock = true});
                ++id;
            }
            
            return Coffees;
        }



    }
}
