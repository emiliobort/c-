using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace entregable_canodromo
{
    public partial class Form1 : Form
    {

        int Apostante;//Jugador que apuesta actualmente
        int Ganador;//Variable utilizada para definir el galgo ganador
        

        //Declaración de los participantes, de sus apuestas y de los galgos respecto de sus clases propias
        Jugador Jugador1, Jugador2, Jugador3;
        Apuesta AJugador1, AJugador2, AJugador3;
        Galgo Galgo1, Galgo2, Galgo3, Galgo4;

        Jugador[] Jugadores;//Creación de array para meter a los jugadores
        Galgo[] Galgos;//Creación de array para meter los galgos

        public Form1()
        {
            
            InitializeComponent();

            


            // Creación de Jugadores
            Jugador1 = new Jugador("Jugador1", radioButton1, label1);
            Jugador2 = new Jugador("Jugador2", radioButton2, label2);
            Jugador3 = new Jugador("Jugador3", radioButton3, label3);
            // Creación de Apuestas
            AJugador1 = new Apuesta(Jugador1);
            AJugador2 = new Apuesta(Jugador2);
            AJugador3 = new Apuesta(Jugador3);
            //Asignación de apuestas a Jugadores
            Jugador1.MiApuesta = AJugador1;
            Jugador2.MiApuesta = AJugador2;
            Jugador3.MiApuesta = AJugador3;


            Jugadores =  new Jugador[3]{ Jugador1, Jugador2, Jugador3 };//Array con los jugadores completo


            //Creación de los galgos a partir de las imagenes de los perros
            Galgo1 = new Galgo(Perro1);
            Galgo2 = new Galgo(Perro2);
            Galgo3 = new Galgo(Perro3);
            Galgo4 = new Galgo(Perro4);


            Galgos = new Galgo[4]{ Galgo1 ,Galgo2 ,Galgo3, Galgo4 };//Array con los galgos completo.
            Galgo.PosicionMeta = PistaImg.Location.X + PistaImg.Size.Width - Perro1.Size.Width;//Calculo de la posición en relacion al tamaño de la imagen del galgo
                                 //Si hubiera diferentes tamaño de imagenes, habria que realizarse este calculo para los distintos tamaños

            foreach (Jugador jugador in Jugadores)//Bucle para actualizar el contenido de las labels correspondientes a cada jugador
            {
                jugador.ActualizaLabels();
            }
        
        }

        private void button2_Click(object sender, EventArgs e)//Boton de empezar la carrera
        {
            Random random = new Random();//Creación de un objeto random
            bool fin = false;// Control del final de la carrera
            while (fin == false)
            {
                for (int i = 0; i < Galgos.Length; i++)
                {

                    PistaImg.Refresh(); //Refresca la imagen de la pista para eliminar el rastro que dejan los galgos.
                    if (Galgos[i].Run(random)) //Hace avanzar a los galgos y comprueba si alguno ha llegado a meta.
                    {
                        fin = true; // Si algun galgo llega a meta
                        Ganador = i + 1; //Sumamos 1 ya que el numericUpDown no empieza por 0 
                        MessageBox.Show("Ha ganado el galgo " + (Ganador));//Mensaje que aparece al acabar la carrera con el numero del galgo ganador
                        break;
                    }
                }
            }
            for (int i = 0; i < Galgos.Length; i++)//Bucle que pone a todos los galgos a la posición inicial al terminar la carrera
            {
                Galgos[i].ASusPuestos();
            }
            for (int i = 0; i < Jugadores.Length; i++)//Metodo que permite variar las cantidades de dinero de los jugadores y volver las labels de apuestas a su estado inicial
            {
                Jugadores[i].Recoger(Ganador);
                Jugadores[i].EliminaApuesta();
                Jugadores[i].ActualizaLabels();
            }   
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Indica el apostante y pone el texto apropiado en la label correspondiente
        {
            Apostante= 0;
            label4.Text = Jugadores[Apostante].Nombre + " apuesta";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Indica el apostante y pone el texto apropiado en la label correspondiente
        {
            Apostante = 1;
            label4.Text = Jugadores[Apostante].Nombre + " apuesta";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//Indica el apostante y pone el texto apropiado en la label corrrespondiente
        {
            Apostante = 2;
            label4.Text = Jugadores[Apostante].Nombre + " apuesta";
        }

        private void Botonapuesta_Click(object sender, EventArgs e)
        {
            int apuesta = (int)numericDinero.Value;
            int perro = (int)numericPerro.Value;
            Jugadores[Apostante].Apostar(apuesta, perro);// Si tiene dinero suficiente realizará la apuesta de dinero establecido al perro establecido

            Jugadores[Apostante].MiLabel.Text = Jugadores[Apostante].MiApuesta.GetDescripcion();
            Jugadores[Apostante].MiRadioButton.Text = Jugadores[Apostante].Nombre + " tiene " + (Jugadores[Apostante].Cartera - Jugadores[Apostante].MiApuesta.Cantidad) + "€";
        }

        private void numericDinero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancela1_Click(object sender, EventArgs e)//Actualiza la label correspondiente al jugador y la devuelve a su estado inicial
        {
            AJugador1.Cantidad = 0;
            Jugador1.ActualizaLabels();
        }

        private void Cancela2_Click(object sender, EventArgs e)//Actualiza la label correspondiente al jugador y la devuelve a su estado inicial
        {
            AJugador2.Cantidad = 0;
            Jugador2.ActualizaLabels();
        }

        private void Cancela3_Click(object sender, EventArgs e)//Actualiza la label correspondiente al jugador y la devuelve a su estado inicial
        {
            AJugador3.Cantidad = 0;
            Jugador3.ActualizaLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
