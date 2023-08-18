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
using System.Windows;
using System.Windows.Input;

namespace ProjectWorkONWPF.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand saveCommand { get; private set; }
        public ProductViewModel()
        {
            saveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            if (!string.IsNullOrWhiteSpace(Name) &&
                !string.IsNullOrWhiteSpace(Price) &&
                !string.IsNullOrWhiteSpace(Quantity) &&
                !string.IsNullOrWhiteSpace(Description))
            {
                try
                {
                    var tempPrice = decimal.Parse(Price);
                    var tempQuantity = uint.Parse(Quantity);
                    using (var dbContext = new MyDbContext())
                    {
                        var product = dbContext.Products.FirstOrDefault(product => product.Name == Name);
                        if (product == null)
                        {
                            Product new_product = new Product()
                            {
                                Name = Name,
                                Price = tempPrice,
                                Quantity = tempQuantity,
                                Description = Description
                            };
                            dbContext.Products.Add(new_product);
                            dbContext.SaveChanges();
                            MessageBox.Show("Product was succesfully added", "Success", MessageBoxButton.OK);
                        }
                        else
                        {
                            product.Quantity += tempQuantity;
                            product.Price = tempPrice;
                            product.Description = Description;
                            dbContext.Update(product);
                            dbContext.SaveChanges();
                            MessageBox.Show("Database info was succesfully updated");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Price or quantity isn't in correct format");
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        private string price;
        private string quantity;
        private string description;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public string Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }

    }
}
