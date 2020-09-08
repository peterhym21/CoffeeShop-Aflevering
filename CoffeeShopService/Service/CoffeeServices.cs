using CoffeeShopService.DTO;
using CoffeeShopService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.Service
{
    public class CoffeeServices : ICoffeeService
    {
        public void DeleteCoffe(Coffee coffee)
        {
            throw new NotImplementedException();
        }

        public Coffee GetCoffee()
        {
            throw new NotImplementedException();
        }

        public Coffee GetCoffeeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coffee> GetCoffees()
        {
            throw new NotImplementedException();
        }

        public void LoadCoffees()
        {
            CreateCoffees();
            
        }

        public void UpdateCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }


    }
}
