using System.Collections.ObjectModel;
using System.ComponentModel;

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
        private bool _smoking;
        private bool _pets;
        private bool _wifi;
        private double _price;
        private string _description;
        private ObservableCollection<Reservation> _reservations;

        public int Id { get; set; }
        public int LandlordId
        {
            get => _landlordId;
            set
            {
                _landlordId = value;

                Notify("LandlordId");
            }
        }
        public Landlord Landlord { get; set; }
        public TypeHouse TypeHouse
        {
            get => _typeHouse;
            set
            {
                _typeHouse = value;

                Notify("TypeHouse");
            }
        }
        public string HouseAdress
        {
            get => _houseadress;
            set
            {
                _houseadress = value;

                Notify("HouseAdress");
            }
        }
        public string HouseCity
        {
            get => _housecity;
            set
            {
                _housecity = value;

                Notify("HouseCity");
            }
        }
        public int NumberOfRooms
        {
            get => _numberOfRooms;
            set
            {
                _numberOfRooms = value;

                Notify("NumberOfRooms");
            }
        }
        public int NumberOfBeds
        {
            get => _numberOfBeds;
            set
            {
                _numberOfBeds = value;

                Notify("NumberOfBeds");
            }
        }
        public int MaxPeople
        {
            get => _maxPeople;
            set
            {
                _maxPeople = value;

                Notify("MaxPeople");
            }
        }
        public bool Smoking
        {
            get => _smoking;
            set
            {
                _smoking = value;

                Notify("Smoking");
            }
        }
        public bool Pets
        {
            get => _pets;
            set
            {
                _pets = value;

                Notify("Pets");
            }
        }
        public bool Wifi
        {
            get => _wifi;
            set
            {
                _wifi = value;

                Notify("Wifi");
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                _price = value;

                Notify("Price");
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;

                Notify("Description");
            }
        }

        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }

        public ObservableCollection<Reservation> Reservations
        {
            get => _reservations;
            set
            {
                _reservations = value;

                Notify("Houses");
            }
        }
    }

}
