﻿using Globomantics.Math;
using System.Windows;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Calculator.Add(12, 2).ToString());
        }
    }
}