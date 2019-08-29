using MahApps.Metro.Controls;
using MoneyStat.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MoneyStat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow,INotifyPropertyChanged
    {
        public float Profit { get; set; }
        public float Spending { get; set; }
        public float Balance { get; set; }

        private Brush balanceBorderColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public Brush BalanceBorderColor {
            get
            {
                return balanceBorderColor;
            }
            set
            {
                balanceBorderColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BalanceBorderColor"));
            }

        }

        public MainWindow()
        {
            InitializeComponent();

            BalanceBorderColor = new SolidColorBrush(Colors.LightGreen);

            Profit = 0;
            Spending = 0;
            Balance = Spending - Profit;

            
            this.DataContext = this;
        }       
      
        public void AddProfit()
        {
            AddProfitWindow window = new AddProfitWindow();
            window.ShowDialog();
        }

        public void AddSpending()
        {
            AddSpendingWindow window = new AddSpendingWindow();
            window.ShowDialog();
        }

        public void AddCategory()
        {
            AddCategoryWindow window = new AddCategoryWindow();
            window.ShowDialog();
        }

        public void OpenAllStats()
        {

        }

        public void OpenAllProfit()
        {

        }

        public void OpenAllSpending()
        {

        }

        private void AddProfitClick(object sender, RoutedEventArgs e)
        {
            AddProfit();
        }

        private void AddSpendingClick(object sender, RoutedEventArgs e)
        {
            AddSpending();
        }

        private void AddCategoryClick(object sender, RoutedEventArgs e)
        {
            AddCategory();
        }
    }
}
