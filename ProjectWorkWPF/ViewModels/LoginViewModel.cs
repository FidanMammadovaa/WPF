using ProjectWorkWPF.Context;
using ProjectWorkWPF.Сores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectWorkONWPF.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand loginCommand { get; private set; }

        public LoginViewModel()
        {
            loginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
            {
                using (var context = new MyDbContext())
                {
                    var user = context.Users.FirstOrDefault(user => user.Username == Username);
                    if (user != null)
                    {
                        if (user.Password != Password)
                        {
                            MessageBox.Show("Wrong password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MenuWindow menuWindow = new();
                            menuWindow.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no users with that username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string username;
        private string password;
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
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
