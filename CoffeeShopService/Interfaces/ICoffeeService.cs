using CoffeeShopService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.Interfaces
{
    public interface ICoffeeService
    {
        void DeleteCoffe(Coffee coffee);
        Coffee GetCoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
        void LoadCoffees();

    }
}
