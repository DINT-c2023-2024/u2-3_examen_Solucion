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

namespace u2_3_examen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int vecesAceptar;
        private int vecesCancelar;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int veces;
            if (b.Content.Equals("Aceptar")) {       // También se puede hacer con "Tag".
                vecesAceptar++;
                veces = vecesAceptar;
            }
            else {
                vecesCancelar++;
                veces = vecesCancelar;
            }
            String message = "El botón se ha pulsado " + (veces==1? "una vez" : $"{veces} veces");
            MessageBox.Show(message);
        }

        private void añadirButton_Click(object sender, RoutedEventArgs e)
        {
            TextBlock t = new TextBlock();           // Las siguientes propiedades también se puden definir
            t.Text = textoTextBox.Text;              // en "Window.Resources" como un "Style" y luego asignar.
            t.Background = Brushes.IndianRed;
            t.Margin = new Thickness(5);
            t.Padding = new Thickness(5);
            t.Foreground = Brushes.White;
            t.Height = 35;
            t.FontSize = 18;
            contenedorWrapPanel.Children.Add(t);
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(textoTextBox.Text)) añadirButton.IsEnabled = false;
            else añadirButton.IsEnabled = true;
        }
    }
}
