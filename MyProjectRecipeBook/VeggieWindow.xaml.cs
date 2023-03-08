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
    /// Interaction logic for VeggieWindow.xaml
    /// </summary>
    public partial class VeggieWindow : Window
    {
        public VeggieWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();

        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Button_Click_New_Window(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            this.Visibility = Visibility.Hidden;
            newWindow.Show();
        }
    }
}
