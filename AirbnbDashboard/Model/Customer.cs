using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbDashboard.Model
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName;
        private string _lastName;
        private string _email;
        private ObservableCollection<Reservation> _reservations;

        public int id { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;

                Notify("Firstname");
            }
        }
        public string Lastname
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;

                Notify("Lastname");
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;

                Notify("Email");
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

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));
            }
        }
    }
}

