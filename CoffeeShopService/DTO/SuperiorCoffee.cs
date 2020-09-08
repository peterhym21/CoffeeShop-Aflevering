using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.DTO
{
    public class SuperiorCoffee : Coffee, INotifyPropertyChanged
    {
        private string _extraDescription;

        public string ExtraDescription 
        {
            get => _extraDescription; set
            {
                _extraDescription = value;
                OnPropertyChanged();
            }
        }

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // take a copy to prevent thread issues
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
