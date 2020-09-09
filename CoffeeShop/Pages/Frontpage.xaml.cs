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
    /// Interaction logic for Frontpage.xaml
    /// </summary>
    public partial class Frontpage : Page
    {
        public List<Coffee> CoffeeList { get; set; }
        public Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public Frontpage()
        {
            CoffeeList = new List<Coffee>();
            Coffees = new Coffee();
            CoffeeServicess = new CoffeeServices();
            InitializeComponent();
            foreach (Coffee coffee in CoffeeServicess.GetCoffees())
            {
                CoffeeList.Add(coffee);
            }
            CoffeePreview.ItemsSource = CoffeeList;
        }

        private void MoreInfo(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;
            CoffeeInformation details = new CoffeeInformation(id);
            NavigationService.Navigate(details);

        }

        private void AdminPage(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin(Coffees, CoffeeServicess, CoffeeList);
            NavigationService.Navigate(adminLogin);

        }
    }
}
