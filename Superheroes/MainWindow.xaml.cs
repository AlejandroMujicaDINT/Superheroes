using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Superheroes
{
    
    public partial class MainWindow : Window
    {
        private int indice;

        public int Indice 
        { 
            get => indice; 
            set
            {
                indice = value;
                DataContext = superheroes[indice];
            }
        }


        List<Superheroe> superheroes;
        public MainWindow()
        {
            InitializeComponent();

            superheroes = Superheroe.GetSamples();
            Indice = 0;
            heroeRadioButton.IsChecked = true;

        }

        private void NumeroDeImagenes()
        {
            numeroImagenes.Text = (Indice+1) + "/" + superheroes.Count; 
        }

        private void Image_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            string flecha = ((Image)sender).Tag.ToString();

            if(flecha=="-1" && DataContext != superheroes[0])
            {
                Indice--;
                NumeroDeImagenes();
            }
            else if(flecha=="1" && DataContext != superheroes[superheroes.Count-1])
            {
                Indice++;
                NumeroDeImagenes();
            }
        }

        private void Limpiar()
        {
            nombreTextBox.Text = "";
            urlImageTextBox.Text = "";
            heroeRadioButton.IsChecked = true;
            vengadorCheckBox.IsChecked = false;
            xmenCheckBox.IsChecked = false;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            superheroes.Add((Superheroe)Resources["nuevoSuperheroe"]);
            Resources["nuevoSuperheroe"] = new Superheroe();
            NumeroDeImagenes();
            Limpiar();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void villanoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            vengadorCheckBox.IsChecked = false;
            xmenCheckBox.IsChecked = false;
        }
    }
}
