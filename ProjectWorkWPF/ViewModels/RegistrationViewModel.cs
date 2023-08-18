using ProjectWorkWPF.Context;
using ProjectWorkWPF.Entities;
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

namespace ProjectWorkWPF.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        public ICommand submitCommand { get; private set; }
        public RegistrationViewModel()
        {
            submitCommand = new RelayCommand(Submit);
        }

        private string username;
        private string password;
        private string confirm;
        private string name;
        private string surname;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }

        public string Confirm
        {
            get { return confirm; }
            set { confirm = value; OnPropertyChanged(); }
        }

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

        private void Submit()
        {
            string regexStringForUsernameAndPassword = @"^[a-zA-Z0-9]{5,25}$";
            string regexString = @"[a-zA-Z]+";


            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Confirm) && !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Surname))
            {
                if (Regex.IsMatch(Username, regexStringForUsernameAndPassword) &&
                        Regex.IsMatch(Name, regexString) &&
                        Regex.IsMatch(Surname, regexString) &&
                        Regex.IsMatch(Password, regexStringForUsernameAndPassword) &&
                        Regex.IsMatch(Confirm, regexStringForUsernameAndPassword))

                {
                    if (Password == Confirm)
                    {
                        using (var dbContext = new MyDbContext())
                        {
                            if (!dbContext.Users.Any(u => u.Username == Username))
                            {
                                User newUser = new User
                                {
                                    Username = Username,
                                    Password = Password,
                                    Name = Name,
                                    Surname = Surname
                                };
                                dbContext.Users.Add(newUser);
                                dbContext.SaveChanges();
                                MessageBox.Show("User was succesfully added", "Success", MessageBoxButton.OK);
                            }
                            else
                            {
                                MessageBox.Show("User with that nickname already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Name and Surname should contain at least 1 symbol\n Username, Password, Confirm should contain at least 5 elements, maximum 25\n Username, Password, Confirm can't contain special symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
