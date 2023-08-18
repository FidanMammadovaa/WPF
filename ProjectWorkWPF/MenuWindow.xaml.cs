using Microsoft.EntityFrameworkCore;
using ProjectWorkONWPF.ViewModels;
using ProjectWorkWPF.Context;
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
using System.Windows.Shapes;

namespace ProjectWorkONWPF
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addClientButton_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
        }

        private void listClientButton_Click(object sender, RoutedEventArgs e)
        {
            clientView.Visibility = Visibility.Visible;
            orderView.Visibility = Visibility.Hidden;
            productView.Visibility = Visibility.Hidden;
            using (var dbContext = new MyDbContext())
            {
                var clients = dbContext.Clients.ToList();
                clientView.ItemsSource = clients;
            }
        }

        private void addOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new();
            orderWindow.ShowDialog();
        }

        private void listOrderButton_Click(object sender, RoutedEventArgs e)
        {
            orderView.Visibility = Visibility.Visible;
            clientView.Visibility = Visibility.Hidden;
            productView.Visibility = Visibility.Hidden;
            using (var dbContext = new MyDbContext())
            {
                var orders = dbContext.Orders.Include(o => o.Client).Include(o => o.Product).ToList();
                orderView.ItemsSource = orders;
            }
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new();
            productWindow.ShowDialog();
        }

        private void listProductButton_Click(object sender, RoutedEventArgs e)
        {
            productView.Visibility = Visibility.Visible;
            clientView.Visibility = Visibility.Hidden;
            orderView.Visibility = Visibility.Hidden;
            using (var dbContext = new MyDbContext())
            {
                var products = dbContext.Products.ToList();
                productView.ItemsSource = products;
            }
        }
    }
}
