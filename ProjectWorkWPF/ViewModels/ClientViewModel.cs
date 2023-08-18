using ProjectWorkONWPF.Entities;
using ProjectWorkWPF.Context;
using ProjectWorkWPF.Сores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectWorkONWPF.ViewModels
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public ICommand saveCommand { get; private set; }
        public ClientViewModel()
        {
            saveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            string regexStringForEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string regexStringForPhoneNumber = @"^\+994\d{9}$";
            string regexString = @"[a-zA-Z]+";
            if (!string.IsNullOrWhiteSpace(Name) &&
                !string.IsNullOrWhiteSpace(Surname) &&
                !string.IsNullOrWhiteSpace(Email) && 
                !string.IsNullOrWhiteSpace(PhoneNumber) && 
                !string.IsNullOrWhiteSpace(Address))
            {
                if (Regex.IsMatch(Email, regexStringForEmail) &&
                    Regex.IsMatch(PhoneNumber, regexStringForPhoneNumber) &&
                    Regex.IsMatch(Name, regexString) &&
                    Regex.IsMatch(Surname, regexString) &&
                    Regex.IsMatch(Address, regexString))
                {
                    using (var dbContext = new MyDbContext())
                    {
                        Client client = new Client()
                        {
                            Name = Name,
                            Surname = Surname,
                            Email = Email,
                            PhoneNumber = PhoneNumber,
                            Address = Address
                        };
                        dbContext.Clients.Add(client);
                        dbContext.SaveChanges();
                        MessageBox.Show("Client was succesfully added", "Success", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Name and surname should contain at least 1 symbol\n Phone number should contain 13 symbols and start as +994\n And email should match the basic regular expression as always", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        private string surname;
        private string email;
        private string phoneNumber;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged(); }
        }

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged(); }
        }

    }
}
