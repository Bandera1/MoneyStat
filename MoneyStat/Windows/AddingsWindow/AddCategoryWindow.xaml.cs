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
using MahApps.Metro.Controls.Dialogs;
using MoneyStat.EnititiesClasses;
using MoneyStat.DatabaseServices;

namespace MoneyStat.Windows
{
    /// <summary>
    /// Interaction logic for AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : MetroWindow
    {
        public Categories NewCategory { get; set; }

        public AddCategoryWindow()
        {
            InitializeComponent();

            NewCategory = new Categories();

            this.DataContext = this;           
        }       

        private  void AddCategory(object sender, RoutedEventArgs e)
        {
            ProfitsAndSpendingsService Service = new ProfitsAndSpendingsService();
            

            if (NewCategory.Name == null)
            {
                this.ShowMessageAsync("Error", "Category name can`t be empty.", MessageDialogStyle.Affirmative);
                return;
            }

            if(Service.AddCategory(NewCategory) == false)
            {
                this.ShowMessageAsync("Error", "Category alredy exists.", MessageDialogStyle.Affirmative);
                return;
            }

            this.ShowMessageAsync("Success", $"Category {NewCategory.Name} added.", MessageDialogStyle.Affirmative);

        }
    }
}
