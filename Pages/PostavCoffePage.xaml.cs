﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;


namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PostavCoffePage.xaml
    /// </summary>
    public partial class PostavCoffePage : Page
    {
        public PostavCoffePage()
        {
            InitializeComponent();
            CmbPost.ItemsSource = EslettaEntities.GetContext().products.ToList();
            CmbAdress.ItemsSource = EslettaEntities.GetContext().cafes.ToList();

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы оформили поставку!");
            NavigationService.GoBack();

        }

        private void BtnNaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PostavPage());

        }
    }
}
