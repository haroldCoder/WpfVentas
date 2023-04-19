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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ventas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isMaximized = false;
        private bool isMenuOpen = true;
        private double originalWidth;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MaximizarVentana_Click(object sender, RoutedEventArgs e)
        {
            if (isMaximized)
            {
                // Minimiza la ventana
                WindowState = WindowState.Normal;
                isMaximized = false;
            }
            else
            {
                // Maximiza la ventana
                WindowState = WindowState.Maximized;
                isMaximized = true;
            }
        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            originalWidth = mainGrid.ActualWidth;
            if (isMenuOpen)
            {
                // Reduce el ancho del grid
                mainGrid.Width = 50;

                isMenuOpen = false;
            }
            else
            {
                // Maximiza el ancho del grid
                mainGrid.Width = 200;
                

                isMenuOpen = true;
            }
        }

    }
}
