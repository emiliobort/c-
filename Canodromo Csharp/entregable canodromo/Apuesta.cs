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
    class Apuesta
    {
        public int Cantidad; //Dinero que se apuestan
        public int Perro; //Identificador del perro al que se apuesta
        public Jugador Apostante; // El jugador que realiza la apuesta


        public Apuesta(Jugador Apostante)//Establece el apostante en el momento actual
        {
            this.Apostante = Apostante;
        }

        public string GetDescripcion()
        // Devuelve una cadena que indica qué jugador realizó esta apuesta  cuánto se apostó y sobre qué perro
        
        {
            if (Cantidad != 0)//Comprueba la cantidad de dinero apostada
            {//Si se ha apostado, indica cuanto  y sobre que perro
                return Apostante.Nombre + " apuesta " + Cantidad + " € en el galgo #" + Perro + ".";
            }
            else
            {//Si no se ha apostado, indica que no se ha realizado ninguna apuesta
                return Apostante.Nombre + " no ha apostado en esta carrera.";
            }
        }

        public void Pagos(int Ganador)
        //Si el perro de esta apuesta es el ganador, se devuelve Cantidad,en otro caso se devuelve – Cantidad.
        
        {
            if (Perro == Ganador) Apostante.Cartera += Cantidad;
            else Apostante.Cartera -= Cantidad;
        }
    }
}
