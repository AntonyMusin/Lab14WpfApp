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

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName="Рыба",
                ProductCost=350,
                ProductImage="Data/Fish.png",
                ProductType=ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductCost = 50,
                ProductImage = "Data/Bread.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Ананас",
                ProductCost = 150,
                ProductImage = "Data/Pineapple.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                ProductCost = 35000,
                ProductImage = "Data/WashingMachine.png",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                ProductCost = 5000,
                ProductImage = "Data/Microwave.png",
                ProductType = ProductTypes.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
