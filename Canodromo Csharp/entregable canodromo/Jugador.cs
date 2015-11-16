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
    class Jugador
    {
        public string Nombre;
        public Apuesta MiApuesta;
        public int Cartera;
        public RadioButton MiRadioButton;
        public Label MiLabel;


        public Jugador(string Nombre, RadioButton MiRadioButton, Label MiLabel)//Indica la correspondencia del jugador con el radio button y su label correspondiente
        {//Indica el dinero el nombre el radio buton y la label del jugador actual
            this.Nombre = Nombre;
            Cartera = 100;
            this.MiRadioButton = MiRadioButton;
            this.MiLabel = MiLabel;
        }

        public void ActualizaLabels()
        //Actualiza MiLabel a la descripción de mi apuesta
        //Y la etiqueta de miRadioButton para mostrar mi cartera
       
        {
            MiRadioButton.Text = Nombre + " tiene " + Cartera + "€";
            MiLabel.Text = MiApuesta.GetDescripcion();

        }


        public void Apostar(int Cantidad, int Perro)
        
        {
            if (Cantidad <= Cartera)//Comprueba el dinero apostado y si es psoible apostarlo
            {
                MiApuesta.Cantidad = Cantidad;
                MiApuesta.Perro = Perro;
            }
            else MessageBox.Show("No tienes suficiente dinero");//Mensaje que aparece si no se dispone del saldo suficiente
        }


        public void EliminaApuesta()//Metodo para dejar la label del jugador al valor inicial
        {
            MiApuesta.Cantidad = 0;
        }
        public void Recoger(int Ganador)
        {
            // Hacer que MiApuesta recoja beneficios o pérdidas
            MiApuesta.Pagos(Ganador);
        }


    }
}
