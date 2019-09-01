using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MoneyStat.DatabaseServices;
using MoneyStat.EnititiesClasses;
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
        public ProfitsAndSpendings NewMoneyNode { get; set; }
        private ProfitsAndSpendingsService Service = new ProfitsAndSpendingsService();


        public AddProfitWindow()
        {
            InitializeComponent();
            this.DataContext = this;


            NewMoneyNode = new ProfitsAndSpendings();


            var categories = Service.GetCategories();
            CategoryComboBox.ItemsSource = categories;          
            if (categories[0] != null)
            {
                CategoryComboBox.SelectedItem = categories[0];
            }
                     
        }

        public void AddProfit()
        {
            NewMoneyNode.Category = CategoryComboBox.SelectedItem as Categories;
            NewMoneyNode.Type = Service.GetMoneyNodeType("Profit");

            if(NewMoneyNode.Category.Name == null)
            {
                this.ShowMessageAsync("Error", "Category can`t be empty.", MessageDialogStyle.Affirmative);
                return;
            }

            NewMoneyNode.Date = DateTime.Now;

            Service.AddNewMoneyNode(NewMoneyNode);
            this.ShowMessageAsync("Success", "New profit added.", MessageDialogStyle.Affirmative);
        }

        private void AddProfit_Click(object sender, RoutedEventArgs e)
        {
            AddProfit();
        }
    }
}
