using ProjectWorkWPF.Context;
using ProjectWorkWPF.ViewModels;
using ProjectWorkWPF.Сores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectWorkWPF
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationViewModel ViewModel { get; set; }
        public RegistrationWindow()
        {
            InitializeComponent();

            ViewModel = new RegistrationViewModel();
            DataContext = ViewModel;
        }

        private void showPasswordBoxText_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Visibility != Visibility.Hidden)
            {
                passwordBox1.Visibility = Visibility.Hidden;
                passwordBox2.Visibility = Visibility.Visible;
                passwordBox1.Password = passwordBox2.Text;
            }
            else if (passwordBox1.Visibility == Visibility.Hidden)
            {
                passwordBox1.Visibility = Visibility.Visible;
                passwordBox2.Visibility = Visibility.Hidden;
                passwordBox1.Password = passwordBox2.Text;
            }
        }
        private void showConfirmBoxText_Click(object sender, RoutedEventArgs e)
        {
            if (confirmBox1.Visibility != Visibility.Hidden)
            {
                confirmBox1.Visibility = Visibility.Hidden;
                confirmBox2.Visibility = Visibility.Visible;
                confirmBox1.Password = confirmBox2.Text;

            }
            else if (confirmBox1.Visibility == Visibility.Hidden)
            {
                confirmBox1.Visibility = Visibility.Visible;
                confirmBox2.Visibility = Visibility.Hidden;
                confirmBox1.Password = confirmBox2.Text;
            }
        }

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordBox2.Text = passwordBox1.Password;
            ViewModel.Password = passwordBox1.Password;
        }

        private void confirmBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            confirmBox2.Text = confirmBox1.Password;
            ViewModel.Confirm = confirmBox1.Password;
        }

    }
}
