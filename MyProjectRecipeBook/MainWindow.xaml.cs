using MyProjectRecipeBook.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;

namespace MyProjectRecipeBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IngridientsViewModel vm = new IngridientsViewModel();
            vm.NeuesIngridient = new Models.Ingridients()
            {
                Bezeichnung = "salt",
                Amount = 1
            };
            vm.FillIngridientsFromDB();
            this.DataContext = vm;

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateText.Text = DateTime.Now.ToString("HH:mm:s d/MM/yy ");
            }, this.Dispatcher);

        }
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            IngridientsViewModel vm = this.DataContext as IngridientsViewModel;
            vm.AddIngridient();
        }


        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            IngridientsViewModel vm = this.DataContext as IngridientsViewModel;
            vm.DeleteProdukt( vm.DeleteId);
            MessageBox.Show("Deleted ingridient");
        }
        private void ButtonSuchen_Click(object sender, RoutedEventArgs e)
        {
            IngridientsViewModel vm = this.DataContext as IngridientsViewModel;
            vm.FilterIngridients();

        }
        private void MenuItem_Vegan_Click(object sender, RoutedEventArgs e)
        {
            mainBox1.Background = Brushes.RosyBrown;
        }

        private void MenuItem_Veggeterian_Click(object sender, RoutedEventArgs e)
        {
            mainBox.Background = Brushes.RosyBrown;
        }

        private void MenuItem_Deserts_Click(object sender, RoutedEventArgs e)
        {
            mainBox3.Background = Brushes.RosyBrown;

        }

        private void MenuItem_Everything_Click(object sender, RoutedEventArgs e)
        {
            mainBox2.Background = Brushes.RosyBrown;
        }

        private void MenuItem_Return_Click(object sender, RoutedEventArgs e)
        {
            mainBox.Background = Brushes.Beige;
            mainBox1.Background = Brushes.Beige;
            mainBox2.Background = Brushes.Beige;
            mainBox3.Background = Brushes.Beige;

        }

        private void startCooking(object sender, RoutedEventArgs e)
        {
            VeggieWindow veggieWindow = new VeggieWindow();
            this.Visibility = Visibility.Hidden;
            veggieWindow.Show();


        }

        private void startCooking1(object sender, RoutedEventArgs e)
        {
            VeganWindow veganWindow = new VeganWindow();
            this.Visibility = Visibility.Hidden;
            veganWindow.Show();
            IngridientsViewModel vm = this.DataContext as IngridientsViewModel;
            veganWindow.DataContext = vm;
            

        }
        private void startCooking2(object sender, RoutedEventArgs e)
        {
            PizzaWindow pizzaWindow = new PizzaWindow();
            this.Visibility = Visibility.Hidden;
            pizzaWindow.Show();


        }
        private void startCooking3(object sender, RoutedEventArgs e)
        {
            MuffinWindow muffinWindow = new MuffinWindow();
            this.Visibility = Visibility.Hidden;

            muffinWindow.Show();
        }


        private void CheckBoxChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Muffins are ready in 10 minutes!");
            text4.Background = Brushes.RosyBrown;

        }
        private void CheckBoxChecked1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vegan tacos  are ready in 15 minutes!");
            text3.Background = Brushes.RosyBrown;
        }
        private void CheckBoxChecked2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pizza Salami  are ready in 30 minutes!");
            text2.Background = Brushes.RosyBrown;
        }
        private void CheckBoxChecked3(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Veggie Lasagne are ready in 40 minutes!");
            text1.Background = Brushes.RosyBrown;

        }

       
    }
}
