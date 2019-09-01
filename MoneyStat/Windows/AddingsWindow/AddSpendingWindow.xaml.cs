using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MoneyStat.DatabaseServices;
using MoneyStat.EnititiesClasses;
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
        public ProfitsAndSpendings NewMoneyNode { get; set; }
        private ProfitsAndSpendingsService Service = new ProfitsAndSpendingsService();



        public AddSpendingWindow()
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

        private void AddSpending()
        {
            NewMoneyNode.Category = CategoryComboBox.SelectedItem as Categories;
            NewMoneyNode.Type = Service.GetMoneyNodeType("Spending");

            if (NewMoneyNode.Category.Name == null)
            {
                this.ShowMessageAsync("Error", "Category can`t be empty.", MessageDialogStyle.Affirmative);
                return;
            }

            NewMoneyNode.Date = DateTime.Now;

            Service.AddNewMoneyNode(NewMoneyNode);
            this.ShowMessageAsync("Success", "New profit added.", MessageDialogStyle.Affirmative);
        }

        private void AddSpending(object sender, RoutedEventArgs e)
        {
            AddSpending();
        }
    }
}
