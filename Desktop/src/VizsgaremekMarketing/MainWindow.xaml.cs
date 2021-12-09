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
using VizsgaremekMarketing.Navigation;
using VizsgaremekMarketing.Pages;

namespace VizsgaremekMarketing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Statikus osztály a Navigate
            //Eltárolja a nyitó ablakot, hogy azon tudjuk módosítani a "page"-ket
            Navigate.mainwindow = this;
            //Létrehozzuk a nyitó "UserControl"(WelcomPage)
            WelcomePage welcomepage = new WelcomePage();
            //Megjelenítjük a WelcomePage
            Navigate.Navigation(welcomepage);
            
        }
        /// <summary>
        /// ListView elemen bal egér bgomb fel lett engedve
        /// </summary>
        /// <param name="sender">ListView amin megnyomtuk a bal egér gombot</param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListView lvMenu = sender as ListView;
            ListViewItem lvMenuItem = lvMenu.SelectedItem as ListViewItem;

            if (lvMenuItem != null)
            {
                switch (lvMenuItem.Name)
                {
                    case "lvExit":
                        Close();
                        break;
                }
            }
        }
    }
}
