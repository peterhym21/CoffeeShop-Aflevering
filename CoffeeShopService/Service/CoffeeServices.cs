using CoffeeShopService.DTO;
using CoffeeShopService.Interfaces;
using CoffeeShopService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.Service
{
    public class CoffeeServices : ICoffeeService
    {
        private Coffee Coffee = new Coffee();

        private static List<Coffee> coffees = new List<Coffee>();

        public void DeleteCoffe(Coffee coffee)
        {
            for (int i = 0; i < coffees.Count; i++)
            {
                if (i == coffee.CoffeeId)
                {
                    coffees.RemoveAt(i);
                }
            }
        }

        public Coffee GetCoffee()
        {
            throw new NotImplementedException();
        }

        public Coffee GetCoffeeById(int id)
        {
            foreach (Coffee findcoffee in coffees)
            {
                if (id == findcoffee.CoffeeId)
                {
                    Coffee = findcoffee;
                    break;
                }
                else
                {
                    Coffee = null;
                }
            }
            return Coffee;
        }

        public List<Coffee> GetCoffees()
        {
            return coffees;
        }

        public void LoadCoffees()
        {
            CoffeeRepository coffeeRepository = new CoffeeRepository();
            coffees = coffeeRepository.CreateCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            foreach (Coffee c in coffees)
            {
                if (c.CoffeeId == coffee.CoffeeId)
                {
                    c.AmountInStock = coffee.AmountInStock;
                    c.CoffeeId = coffee.CoffeeId;
                    c.CoffeeName = coffee.CoffeeName;
                    c.Description = coffee.Description;
                    c.FirstAddedToStockDate = coffee.FirstAddedToStockDate;
                    c.ImageId = coffee.ImageId;
                    c.InStock = coffee.InStock;
                    c.OriginContry = coffee.OriginContry;
                    c.Price = coffee.Price;
                }
            }

        }

        public void CreateCoffe(Coffee coffee)
        {
            foreach (Coffee c in coffees)
            {
                if (c.CoffeeId == coffee.CoffeeId)
                {
                    c.AmountInStock = coffee.AmountInStock;
                    c.CoffeeId = coffee.CoffeeId;
                    c.CoffeeName = coffee.CoffeeName;
                    c.Description = coffee.Description;
                    c.FirstAddedToStockDate = coffee.FirstAddedToStockDate;
                    c.ImageId = coffee.ImageId;
                    c.InStock = coffee.InStock;
                    c.OriginContry = coffee.OriginContry;
                    c.Price = coffee.Price;
                }
            }

        }


    }
}
