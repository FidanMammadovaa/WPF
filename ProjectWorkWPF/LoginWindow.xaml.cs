using ProjectWorkONWPF;
using ProjectWorkONWPF.ViewModels;
using ProjectWorkWPF.Context;
using ProjectWorkWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectWorkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginViewModel ViewModel { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }

        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new();
            registrationWindow.ShowDialog();
        }



        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Text = passwordBox.Password;
            ViewModel.Password = passwordBox.Password;
        }

        private void showPasswordBoxText_Click(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox.Visibility != Visibility.Hidden)
            {
                passwordTextBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Visible;
                passwordBox.Password = passwordTextBox.Text;
            }
            else if (passwordTextBox.Visibility == Visibility.Hidden)
            {
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Hidden;
                passwordBox.Password = passwordTextBox.Text;
            }
        }
    }

}
