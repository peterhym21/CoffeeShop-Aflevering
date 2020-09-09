using CoffeeShop.Pages;
using CoffeeShopService.DTO;
using CoffeeShopService.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Page
    {
        Coffee Coffees { get; set; }
        public CoffeeServices CoffeeServicess { get; set; }
        public ObservableCollection<Coffee> CoffeeListObser { get; set; }


        public AdminPanel(Coffee _coffees, CoffeeServices _coffeeServicess, List<Coffee> _coffeeList)
        {
            Coffees = _coffees;
            CoffeeServicess = _coffeeServicess;
            CoffeeListObser = new ObservableCollection<Coffee>(_coffeeList);
            InitializeComponent();
            CoffeePreview.ItemsSource = CoffeeListObser;
        }

        private void DeleteCoffee(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;
            Coffees = CoffeeServicess.GetCoffeeById(id);
            CoffeeServicess.DeleteCoffe(Coffees);

        }

        private void UpdateCoffee(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;
            List<Coffee> CoffeeList = new List<Coffee>(CoffeeListObser);
            UpdateCoffees update = new UpdateCoffees(Coffees, CoffeeServicess, CoffeeList, id);
            NavigationService.Navigate(update);
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            Frontpage front = new Frontpage();
            NavigationService.Navigate(front);
        }

        private void AddNewCoffee(object sender, RoutedEventArgs e)
        {
            List<Coffee> CoffeeList = new List<Coffee>(CoffeeListObser);
            AddNewCoffee newCoffee = new AddNewCoffee(Coffees, CoffeeServicess, CoffeeList);
            NavigationService.Navigate(newCoffee);
        }
    }
}
