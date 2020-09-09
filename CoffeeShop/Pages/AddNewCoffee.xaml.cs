using CoffeeShopService.DTO;
using CoffeeShopService.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeeShop.Pages
{
    /// <summary>
    /// Interaction logic for AddNewCoffee.xaml
    /// </summary>
    public partial class AddNewCoffee : Page
    {
        Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public List<Coffee> CoffeeList { get; set; }
        public AddNewCoffee(Coffee _coffees, CoffeeServices _coffeeServicess, List<Coffee> _coffeeList)
        {
            Coffees = _coffees;
            CoffeeServicess = _coffeeServicess;
            CoffeeList = _coffeeList;
            InitializeComponent();
        }
    }
}
