using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopService.DTO
{
    public class Coffee : INotifyPropertyChanged
    {
        #region feltes
        private int _coffeeId;
        private string _coffeeName;
        private int _price;
        private string _description;
        private Contry _originContry;
        private bool _inStock;
        private int _amountInStock;
        private DateTime _firstAddedToStockDate;
        private int _imageId;
        #endregion

        #region propertys

        public int CoffeeId
        {
            get => _coffeeId; set
            {
                _coffeeId = value;
                OnPropertyChanged();
            }
        }

        public string CoffeeName
        {
            get => _coffeeName; set
            {
                _coffeeName = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get => _price; set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description; set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public Contry OriginContry
        {
            get => _originContry; set
            {
                _originContry = value;
                OnPropertyChanged();
            }
        }

        public bool InStock
        {
            get => _inStock; set
            {
                _inStock = value;
                OnPropertyChanged();
            }
        }

        public int AmountInStock
        {
            get => _amountInStock; set
            {
                _amountInStock = value;
                OnPropertyChanged();
            }
        }

        public DateTime FirstAddedToStockDate
        {
            get => _firstAddedToStockDate; set
            {
                _firstAddedToStockDate = value;
                OnPropertyChanged();
            }
        }

        public int ImageId
        {
            get => _imageId; set
            {
                _imageId = value;
                OnPropertyChanged();
            }
        }

        public string ImagePath
        {
            get
            {
                return $"../Image/coffee{ImageId}.jpg";
            }
        }

        #endregion
        public Coffee()
        {
        }
        public Coffee(int i)
        {
            CoffeeId = i;
        }

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // take a copy to prevent thread issues
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static implicit operator Coffee(string v)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
