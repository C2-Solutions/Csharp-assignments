using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbDashboard.Model
{
    public class Reservation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _customerId;
        private int _houseId;
        private DateTime _startDate;
        private DateTime _endDate;

        public int id { get; set; }

        public int CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;

                Notify("CustomerId");
            }
        }
        public Customer Customer { get; set; }
        public int HouseId
        {
            get
            {
                return _houseId;
            }
            set
            {
                _houseId = value;

                Notify("HouseId");
            }
        }
        public House House { get; set; }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;

                Notify("StartDate");
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;

                Notify("EndDate");
            }
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));
            }
        }
    }
}
