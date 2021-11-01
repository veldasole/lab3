﻿using System.Windows;
using Лабораторная_1.View;


namespace Лабораторная_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int IdRole { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Employee_OnClick(object sender, RoutedEventArgs
        e)
        {
            WindowEmployee wEmployee = new WindowEmployee();
            wEmployee.Show();
        }
        private void Role_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRole wRole = new WindowRole();
            wRole.Show();
        }
    }
}
