using AirbnbDashboard.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AirbnbDashboard.Classes;

namespace AirbnbDashboard.ViewModel
{
    public class MainWindowViewModel
    {
        public Landlord SelectedLandlord { get; set; }
        public House SelectedHouse { get; set; }
        public ObservableCollection<Landlord> AllLandlords { get; set; }
        public ObservableCollection<House> AllHouses { get; set; }
        public ICommand AddLandlordClick { get; set; }
        public ICommand AddHouseClick { get; set; }
        public ICommand UpdateClick { get; set; }
        public ICommand RemoveLandlordClick { get; set; }
        public ICommand RemoveHouseClick { get; set; }

        private AirbnbDashboardContext _db;

        public MainWindowViewModel()
        {
             _db = new AirbnbDashboardContext();

            _db.Landlords.Include(Landlord => Landlord.Houses).Load();
            _db.Houses.Load();

            AllLandlords = _db.Landlords.Local.ToObservableCollection();
            AllHouses = _db.Houses.Local.ToObservableCollection();

            AddLandlordClick = new RelayCommand(AddLandlord);
            AddHouseClick = new RelayCommand(CreateHouse);
            UpdateClick = new RelayCommand(Update);
            RemoveLandlordClick = new RelayCommand(RemoveLandlord);
            RemoveHouseClick = new RelayCommand(RemoveHouse);
        }

        private void AddLandlord(object a)
        {
            Landlord newLandlord = new Landlord
            {
                FirstName = "Add your firstname here!",
                LastName = "Add your lastname here!",
                Phone = "Add your phonenumber here!",
                Email = "Add your email here!"
            };

            SelectedLandlord = newLandlord;
            AllLandlords.Add(newLandlord);
        }
        private void CreateHouse(object a)
        {
            if (SelectedLandlord != null)
            {
                House newHouse = new House
                {
                    LandlordId = SelectedLandlord.id,
                    TypeHouse = TypeHouse.House,
                    HouseAdress = "Add houseadress here!",
                    HouseCity = "Add city of the house here!",
                    NumberOfRooms = 0,
                    NumberOfBeds = 0,
                    MaxPeople = 0,
                    Smoking = false,
                    Pets = false,
                    Wifi = false,
                    Price = 0,
                    Description = "Add your description here!"
                };

                SelectedHouse = newHouse;
                AllHouses.Add(newHouse);
            }
        }
        private void Update(object a)
        {
            _db.SaveChanges();
        }
        private void RemoveLandlord(object a)
        {
            AllLandlords.Remove(SelectedLandlord);
            _db.SaveChanges();
        }
        private void RemoveHouse(object a)
        {
            AllHouses.Remove(SelectedHouse);
            _db.SaveChanges();
        }


    }
}
