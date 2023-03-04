﻿using MyProjectRecipeBook.ViewModels;
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
        }
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            IngridientsViewModel vm = this.DataContext as IngridientsViewModel;
            vm.AddIngridient();
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
        }
    }
}
