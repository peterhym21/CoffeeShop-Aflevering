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

namespace CoffeeShop
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Page
    {
        Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public List<Coffee> CoffeeList { get; set; }


        public AdminLogin(Coffee _coffees, CoffeeServices _coffeeServicess, List<Coffee> _coffeeList)
        {
            Coffees = _coffees;
            CoffeeServicess = _coffeeServicess;
            CoffeeList = _coffeeList;

            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "Admin" && Password.Password == "1234")
            {
                AdminPanel adminPanel = new AdminPanel(Coffees, CoffeeServicess, CoffeeList);
                NavigationService.Navigate(adminPanel);

            }
            else
            {
                MessageBox.Show("Your Password or username is incorect", "Incorrect", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
