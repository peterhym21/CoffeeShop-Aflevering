using CoffeeShopService.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CoffeeShop.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public Coffee Coffees { get; set; }
        public MainViewModel()
        {
            Coffees = new Coffee();
        
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // take a copy to prevent thread issues
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
