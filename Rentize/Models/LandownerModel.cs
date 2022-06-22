using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb_klas.Model
{
    public class Landlord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _firstname;
        private string _lastname;
        private string _phone;
        private string _email;
        private ObservableCollection<House> _houses;

        public int id { get; set; }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;

                Notify("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;

                Notify("LastName");
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;

                Notify("Phone");
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
        public ObservableCollection<House> Houses
        {
            get
            {
                return _houses;
            }
            set
            {
                _houses = value;

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
