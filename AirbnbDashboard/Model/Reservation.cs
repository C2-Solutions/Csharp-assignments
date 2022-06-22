using System;
using System.ComponentModel;

namespace AirbnbDashboard.Model
{
    public class Reservation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _customerId;
        private int _houseId;
        private DateTime _startDate;
        private DateTime _endDate;

        public int Id { get; set; }

        public int CustomerId
        {
            get => _customerId;
            set
            {
                _customerId = value;

                Notify("CustomerId");
            }
        }
        public Customer Customer { get; set; }
        public int HouseId
        {
            get => _houseId;
            set
            {
                _houseId = value;

                Notify("HouseId");
            }
        }
        public House House { get; set; }

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;

                Notify("StartDate");
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;

                Notify("EndDate");
            }
        }

        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }
    }
}
