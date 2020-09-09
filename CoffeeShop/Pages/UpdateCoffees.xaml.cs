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
    /// Interaction logic for UpdateCoffees.xaml
    /// </summary>
    public partial class UpdateCoffees : Page
    {
        Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public List<Coffee> CoffeeList { get; set; }
        public UpdateCoffees(Coffee _coffees, CoffeeServices _coffeeServicess, List<Coffee> _coffeeList, int id)
        {
            Coffees = _coffees;
            CoffeeServicess = _coffeeServicess;
            CoffeeList = _coffeeList;
            InitializeComponent();
            Coffees = CoffeeServicess.GetCoffeeById(id);
            stackMoreInfo.DataContext = Coffees;
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;
            Coffees = CoffeeServicess.GetCoffeeById(id);

            #region set coffee to the updates
            Coffees.AmountInStock = Convert.ToInt32(Amount.Text);
            Coffees.CoffeeId = id;
            Coffees.CoffeeName = Coffeename.Text;
            Coffees.Description = Description.Text;
            Coffees.InStock = Instock.IsEnabled;
            Coffees.ImageId = Convert.ToInt32(imageid.Text);
            Coffees.Price = Convert.ToInt32(price.Text);
            #endregion

            CoffeeServicess.UpdateCoffee(Coffees);
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(Coffees, CoffeeServicess, CoffeeList);
            NavigationService.Navigate(adminPanel);
        }
    }
}
