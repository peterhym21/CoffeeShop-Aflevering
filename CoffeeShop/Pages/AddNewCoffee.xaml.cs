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

        private void Create(object sender, RoutedEventArgs e)
        {
            #region set coffee to the updates
            Coffees.AmountInStock = Convert.ToInt32(Amount.Text);
            Coffees.CoffeeName = Coffeename.Text;
            Coffees.Description = Description.Text;
            Coffees.InStock = Instock.IsEnabled;
            Coffees.ImageId = Convert.ToInt32(imageid.Text);
            Coffees.Price = Convert.ToInt32(price.Text);
            #endregion

            CoffeeServicess.CreateCoffe(Coffees);
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(Coffees, CoffeeServicess, CoffeeList);
            NavigationService.Navigate(adminPanel);
        }
    }
}
