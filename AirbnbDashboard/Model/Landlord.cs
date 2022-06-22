using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AirbnbDashboard.Model
{
    public class Landlord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _firstname;
        private string _lastname;
        private string _phone;
        private string _email;
        private ObservableCollection<House> _houses;

        public int Id { get; set; }
        public string FirstName
        {
            get => _firstname;
            set
            {
                _firstname = value;

                Notify("FirstName");
            }
        }
        public string LastName
        {
            get => _lastname;
            set
            {
                _lastname = value;

                Notify("LastName");
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;

                Notify("Phone");
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;

                Notify("Email");
            }
        }
        public ObservableCollection<House> Houses
        {
            get => _houses;
            set
            {
                _houses = value;

                Notify("Houses");
            }
        }

        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }
    }
}
