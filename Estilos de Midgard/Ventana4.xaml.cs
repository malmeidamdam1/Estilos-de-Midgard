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

namespace Estilos_de_Midgard
{
    /// <summary>
    /// Lógica de interacción para Ventana4.xaml
    /// </summary>
    public partial class Ventana4 : Window
    {
        public Ventana4()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana2 = new Ventana2();
            ventana2.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Ventana3 ventana3 = new Ventana3();
            ventana3.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ya estas aqui");

        }
    }
}
