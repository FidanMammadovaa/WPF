using ProjectWorkONWPF.Entities;
using ProjectWorkWPF.Context;
using ProjectWorkWPF.Сores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Diagnostics;

namespace ProjectWorkONWPF.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Product> Products { get; set; }
        public List<Client> Clients { get; set; }

        public ICommand saveCommand { get; private set; }
        public OrderViewModel()
        {
            saveCommand = new RelayCommand(Save);
            using (var dbContext = new MyDbContext())
            {
                Products = dbContext.Products.ToList();
                Clients = dbContext.Clients.ToList();
                ArriveTime = DateTime.MinValue;
            }
        }

        private void Save()
        {
            try
            {
                DateTime.TryParse(ArriveTime.ToShortDateString(), out DateTime parsedDate);
                if (!string.IsNullOrWhiteSpace(Client.ToString()) &&
                     !string.IsNullOrWhiteSpace(Product) &&
                     !string.IsNullOrWhiteSpace(Quantity) &&
                     !string.IsNullOrWhiteSpace(ArriveTime.ToShortDateString()))
                {
                    if (ArriveTime.Year >= DateTime.Now.Year &&
                        ArriveTime.Day > DateTime.Now.Day &&
                        ArriveTime.Month >= DateTime.Now.Month)
                    {
                        using (var dbContext = new MyDbContext())
                        {
                            try
                            {
                                var tempQuantity = uint.Parse(Quantity);
                                var product = dbContext.Products.FirstOrDefault(product => product.Quantity >= tempQuantity);
                                if (product != null)
                                {
                                    product.Quantity -= tempQuantity;
                                    dbContext.Update(product);
                                    var FromDbClient = dbContext.Clients.FirstOrDefault(client => client == Client);
                                    Order order = new Order()
                                    {
                                        Client = FromDbClient,  // can't be null, cause we have comboBox with existing users
                                        Product = product,
                                        ArriveTime = ArriveTime,
                                        Quantity = tempQuantity
                                    };
                                    dbContext.Orders.Add(order);

                                    FromDbClient.Orders.Add(order);
                                    dbContext.SaveChanges();
                                    MessageBox.Show("Order was succesfully added");
                                }
                                else
                                {
                                    MessageBox.Show("The stock lacks the quantity.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Quantity isn't in correct format");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid date", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fields can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Date isn't in correct format\n Try dd.MM.yyyy", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Client client;
        private string product;
        private string quantity;
        private DateTime arriveTime;
        public Client Client
        {
            get { return client; }
            set { client = value; OnPropertyChanged(); }
        }

        public string Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged(); }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(); }
        }

        public DateTime ArriveTime
        {
            get { return arriveTime; }
            set { arriveTime = value; OnPropertyChanged(); }
        }

    }
}
