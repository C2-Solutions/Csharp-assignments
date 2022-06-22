using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AirbnbDashboard.Model
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName;
        private string _lastName;
        private string _email;
        private ObservableCollection<Reservation> _reservations;

        public int Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;

                Notify("Firstname");
            }
        }
        public string Lastname
        {
            get => _lastName;
            set
            {
                _lastName = value;

                Notify("Lastname");
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
        public ObservableCollection<Reservation> Reservations
        {
            get => _reservations;
            set
            {
                _reservations = value;

                Notify("Houses");
            }
        }

        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }
    }
}

