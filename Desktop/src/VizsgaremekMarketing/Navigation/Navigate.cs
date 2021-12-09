using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VizsgaremekMarketing.Navigation
{
    public static class Navigate
    {
        // Eltároljuk a MainWindow, hogy tudjunk váltani ablakot(page)
        public static MainWindow mainwindow;

        /// <summary>
        /// Egy új ablakra vált
        /// </summary>
        /// <param name="userControl"></param>
        public static void  Navigation(UserControl userControl)
        {
            mainwindow.PageContent.Children.Add(userControl);
        }
    }
}
