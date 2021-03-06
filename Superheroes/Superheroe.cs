using System.Collections.Generic;
using System.ComponentModel;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen;
        private bool vengador;
        private bool xmen;
        private bool heroe;
        private bool villano;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    NotifyPropetyChanged("Nombre");
                }
            }
        }
        public string Imagen
        {
            get => imagen;
            set
            {
                if (imagen != value)
                {
                    imagen = value;
                    NotifyPropetyChanged("Imagen");
                }
            }
        }
        public bool Vengador
        {
            get => vengador;
            set
            {
                if (vengador != value)
                {
                    vengador = value;
                    NotifyPropetyChanged("Vengador");
                }
            }
        }
        public bool Xmen
        {
            get => xmen;
            set
            {
                if (xmen != value)
                {
                    xmen = value;
                    NotifyPropetyChanged("Xmen");
                }
            }
        }
        public bool Heroe
        {
            get => heroe;
            set
            {
                if (heroe != value)
                {
                    heroe = value;
                    NotifyPropetyChanged("Heroe");
                }
            }
        }
        public bool Villano
        {
            get => villano;
            set
            {
                if (villano != value)
                {
                    villano = value;
                    NotifyPropetyChanged("Villano");
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropetyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://sm.ign.com/ign_latam/screenshot/default/ybbpqktez5whedr0-1592031889_31aa.jpg", true, false, true, false);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false, true);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true, false);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}