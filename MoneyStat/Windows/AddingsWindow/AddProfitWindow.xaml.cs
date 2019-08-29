using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MoneyStat.Windows
{
    /// <summary>
    /// Interaction logic for AddProfitWindow.xaml
    /// </summary>
    public partial class AddProfitWindow : MetroWindow
    {
        //public Category Category { get; set; }
        public float MoneyValue { get; set; }
        public string Description { get; set; }

        public AddProfitWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void AddProfit()
        {

        }

        private void AddProfit_Click(object sender, RoutedEventArgs e)
        {
            AddProfit();
        }
    }
}
