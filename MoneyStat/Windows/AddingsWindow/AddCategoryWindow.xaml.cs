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

namespace MoneyStat.Windows
{
    /// <summary>
    /// Interaction logic for AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : MetroWindow
    {
        public string CategoryName { get; set; }
   
        public AddCategoryWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }       

        private  void AddCategory(object sender, RoutedEventArgs e)
        {
            this.ShowMessageAsync("Title", "Message", MessageDialogStyle.Affirmative);         
        }
    }
}
