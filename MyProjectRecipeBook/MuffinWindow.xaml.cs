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

namespace MyProjectRecipeBook
{
    /// <summary>
    /// Interaction logic for MuffinWindow.xaml
    /// </summary>
    public partial class MuffinWindow : Window
    {
        public MuffinWindow()
        {
            InitializeComponent();
            var ctx = new MyDataContextClass();
            ctx.Farben = new System.Collections.ObjectModel.ObservableCollection<string>
            {
                "PeachPuff",
                "RosyBrown",
                "Beige",
                "LightGrey"
            };
            ctx.Farbe = "Beige";
            this.DataContext = ctx;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
