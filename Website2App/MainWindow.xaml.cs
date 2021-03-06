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

namespace DesktopWebsite
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow(Uri Arg1, String tit)
        {
            InitializeComponent();
            MW.Title = tit;
            BRMain.Source = Arg1;
            System.Net.WebClient webClient = new System.Net.WebClient();
            string favurl = Arg1.ToString();
            favurl += "/favicon.ico";
            Uri favUri = new Uri(favurl);
            this.Icon = BitmapFrame.Create(favUri);
        }
    }
}
