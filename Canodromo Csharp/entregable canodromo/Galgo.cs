using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace entregable_canodromo
{
    class Galgo
    {
        
        public PictureBox MiPictureBox = null; // El objeto para representar al galgo
        public int Posicion; // Posición de MiPictureBox en la calle
        public int PosicionInicial = 0 ; // Posicion inicial del MiPictureBox
        public static int PosicionMeta ; // Longitud de la calle



        public Galgo(PictureBox imagenPerro)//Define la posicion inicial del galgo y la posicion que ocupa respecto del tamaño de la imagen

        {
            MiPictureBox = imagenPerro;
            Posicion = MiPictureBox.Location.X;
            PosicionInicial = Posicion; 
        }

        public bool Run(Random random)//Establece las unidades de desplazamiento del galgo
        {
            int desplazamiento = random.Next(1, 5); // Desplazarse 1, 2, 3 o 4 espacios al azar
            Point p = MiPictureBox.Location;// Recoge la posición actual en la forma
            p.X += desplazamiento;// Añade los espacios a avanzar
            Posicion = p.X;//Indica la posición en la que se encuentra el galgo
            MiPictureBox.Location = p;// Actualiza la posición en la form

            if (Posicion >= PosicionMeta)//Comprobación de la posición del galgo respecto de la meta
            {
                return true;// Devuelve true si he ganado la carrera
            }
            else
            {
                return false;
            }
        }

        public void ASusPuestos()// Inicializar mi posición a la línea de salida
        {
            
            Point p = MiPictureBox.Location;
            p.X = PosicionInicial;
            MiPictureBox.Location = p;
        }

    }
}
