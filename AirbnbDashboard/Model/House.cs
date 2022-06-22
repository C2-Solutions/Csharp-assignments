using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbDashboard.Model
{
    public class House : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _landlordId;
        private TypeHouse _typeHouse;
        private string _houseadress;
        private string _housecity;
        private int _numberOfRooms;
        private int _numberOfBeds;
        private int _maxPeople;
        private bool   _smoking;
        private bool   _pets;
        private bool   _wifi;
        private double _price;
        private string _description;
        private ObservableCollection<Reservation> _reservations;

        public int id { get; set; }
        public int LandlordId
        {
            get
            {
                return _landlordId;
            }
            set
            {
                _landlordId = value;

                Notify("LandlordId");
            }
        }
        public Landlord Landlord {  get; set; }
        public TypeHouse TypeHouse
        {
            get
            {
                return _typeHouse;
            }
            set
            {
                _typeHouse = value;

                Notify("TypeHouse");
            }
        }
        public string HouseAdress
        {
            get
            {
                return _houseadress;
            }
            set
            {
                _houseadress = value;

                Notify("HouseAdress");
            }
        }
        public string HouseCity
        {
            get
            {
                return _housecity;
            }
            set
            {
                _housecity = value;

                Notify("HouseCity");
            }
        }
        public int NumberOfRooms
        {
            get
            {
                return _numberOfRooms;
            }
            set
            {
                _numberOfRooms = value;

                Notify("NumberOfRooms");
            }
        }
        public int NumberOfBeds
        {
            get
            {
                return _numberOfBeds;
            }
            set
            {
                _numberOfBeds = value;

                Notify("NumberOfBeds");
            }
        }
        public int MaxPeople
        {
            get
            {
                return _maxPeople;
            }
            set
            {
                _maxPeople = value;

                Notify("MaxPeople");
            }
        }
        public bool Smoking
        {
            get
            {
                return _smoking;
            }
            set
            {
                _smoking = value;

                Notify("Smoking");
            }
        }
        public bool Pets
        {
            get
            {
                return _pets;
            }
            set
            {
                _pets = value;

                Notify("Pets");
            }
        }
        public bool Wifi
        {
            get
            {
                return _wifi;
            }
            set
            {
                _wifi = value;

                Notify("Wifi");
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;

                Notify("Price");
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;

                Notify("Description");
            }
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));
            }
        }

        public ObservableCollection<Reservation> Reservations
        {
            get
            {
                return _reservations;
            }
            set
            {
                _reservations = value;

                Notify("Houses");
            }
        }
    }

    public enum TypeHouse
    {
        Bungalow, Apartment, House, Villa, Penthouse
    }

}
