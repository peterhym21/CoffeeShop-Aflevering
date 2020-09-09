using CoffeeShopService.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.Repository
{
    public class CoffeeRepository
    {
        public List<Coffee> Coffees { get; set; }

        public List<Coffee> CreateCoffees()
        {
            Coffees = new List<Coffee>();
            int i = 0;
            foreach (string coffeesname in File.ReadAllLines("C:\\skole\\eux\\H2\\WPF\\CoffeeShop\\Starbucks coffee menu.txt"))
            {
                Coffees.Add(new Coffee { CoffeeName = coffeesname, AmountInStock = 10, FirstAddedToStockDate = DateTime.Now, InStock = true, CoffeeId = i, ImageId = new Random().Next(1,9), OriginContry = Contry.Colombia, Price = new Random().Next(30,70)});
                i++;
            }
            i = 0;
            foreach (string coffeesdescription in File.ReadAllLines("C:\\skole\\eux\\H2\\WPF\\CoffeeShop\\Coffee deskription.txt"))
            {
                Coffees[i].Description = coffeesdescription;
                i++;
                
                
            }


            return Coffees;
        }
    }
}
