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
    /// Interaction logic for CoffeeInformation.xaml
    /// </summary>
    public partial class CoffeeInformation : Page
    {
        public Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public CoffeeInformation(int id)
        {
            CoffeeServicess = new CoffeeServices();
            Coffees = new Coffee();
            InitializeComponent();
            Coffees = CoffeeServicess.GetCoffeeById(id);
            stackMoreInfo.DataContext = Coffees;
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            Frontpage front = new Frontpage();
            NavigationService.Navigate(front);
        }
    }
}
