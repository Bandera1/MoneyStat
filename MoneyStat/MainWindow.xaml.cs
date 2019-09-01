using MahApps.Metro.Controls;
using MoneyStat.DatabaseServices;
using MoneyStat.EnititiesClasses;
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

            InitMoneyCount();

           
            this.DataContext = this;
        }       
      
        private void InitMoneyCount()
        {
            ProfitsAndSpendingsService service = new ProfitsAndSpendingsService();

            var _profit = service.GetMoneyNodeValue("Profit");
            var _spending = service.GetMoneyNodeValue("Spending");

            if (_profit == null)
                _profit = 0;

            if (_spending == null)
                _spending = 0;

            Profit = _profit;
            Spending = _spending;
            Balance = Profit - Spending;

            if (Balance < 0)
            {
                balanceBorderColor = new SolidColorBrush(Colors.IndianRed);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BalanceBorderColor"));
            }

            if(Balance >= 0)
            {
                balanceBorderColor = new SolidColorBrush(Colors.LightGreen);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BalanceBorderColor"));
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Profit"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Spending"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Balance"));
        }

        public void AddProfit()
        {
            AddProfitWindow window = new AddProfitWindow();
            window.ShowDialog();

            InitMoneyCount();
        }

        public void AddSpending()
        {
            AddSpendingWindow window = new AddSpendingWindow();
            window.ShowDialog();

            InitMoneyCount();
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
