using MahApps.Metro.Controls;
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

namespace MoneyStat.Windows
{
    /// <summary>
    /// Interaction logic for AddSpendingWindow.xaml
    /// </summary>
    public partial class AddSpendingWindow : MetroWindow
    {
        //public Category Category { get; set; }
        public float MoneyValue { get; set; }
        public string Description { get; set; }


        public AddSpendingWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void AddSpending()
        {

        }

        private void AddSpending(object sender, RoutedEventArgs e)
        {
            AddSpending();
        }
    }
}
