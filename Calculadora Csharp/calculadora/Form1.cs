using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form

    {
        
        // Atributos de la clase.
       
        private bool primerdigito = false; // Controla el primer digito, para borrar la pantalla
        private bool op_pendiente = false; // Maneja si hay o no operación pendiente
        private double operandoranterior; // Almacena el operador anterior
        private string operador = ""; // En este string almacenamos las opciones del switch.
        private const int maximo = 12; // Nos sirve para ver el número máximo de caracteres



        public Calculadora()
        {
            InitializeComponent();
        }


        //Numeros

        private void tecla1_Click(object sender, EventArgs e)
        {
            pulsarNumero(1);
        }

        private void tecla2_Click(object sender, EventArgs e)
        {
            pulsarNumero(2);
        }

        private void tecla3_Click(object sender, EventArgs e)
        {
            pulsarNumero(3);
        }

        private void tecla4_Click(object sender, EventArgs e)
        {
            pulsarNumero(4);
        }

        private void tecla5_Click(object sender, EventArgs e)
        {
            pulsarNumero(5);
        }

        private void tecla6_Click(object sender, EventArgs e)
        {
            pulsarNumero(6);
        }

        private void tecla7_Click(object sender, EventArgs e)
        {
            pulsarNumero(7);
        }

        private void tecla8_Click(object sender, EventArgs e)
        {
            pulsarNumero(8);
        }

        private void tecla9_Click(object sender, EventArgs e)
        {
            pulsarNumero(9);
        }

        private void tecla0_Click(object sender, EventArgs e)
        {
            pulsarNumero(0);
            
        }


        // Accion al pulsar Numero

        public void pulsarNumero(int numero)
        {
             if (primerdigito == false)
            {
                pantalla.Text = Convert.ToString(numero);
                primerdigito = true;
            }
            else
            {
                pantalla.Text += numero;
                Overflow(); // Llamada a la metodo overflow, para ver si tenemos demasiados números.
            }
         
        }

        // Suma

        private void teclasumar_Click(object sender, EventArgs e)
        {
            RealizaCalculos();
            operador = "+";
            primerdigito = false;
         
            if (op_pendiente == false)
            {
                operandoranterior = Convert.ToDouble(pantalla.Text);
                op_pendiente = true;   
            }
            else
            {
                if (pantalla.Text == "0")
                {
                    DesactivarBotones();
                    pantalla.Text = "ERROR";

                }
                else
                {
                    pantalla.Text = Convert.ToString(operandoranterior);
                    Overflow();
                }

            }


        }

        //Resta

        private void teclarestar_Click(object sender, EventArgs e)
        {
            RealizaCalculos();
            operador = "-";;
            primerdigito = false;

            if (op_pendiente == false)
            {
                op_pendiente = true;
                operandoranterior = Convert.ToDouble(pantalla.Text);
            }
            else
            {
                if (pantalla.Text == "0")
                {
                    DesactivarBotones();
                    pantalla.Text = "ERROR";

                }
                else
                {
                    pantalla.Text = Convert.ToString(operandoranterior);
                    Overflow();
                }

            }
                
   
        }

        //Multiplicación

        private void teclamultiplicar_Click(object sender, EventArgs e)
        {

            RealizaCalculos();
            operador = "*";
            primerdigito = false;
            if (op_pendiente == false)
            { 
                operandoranterior = Convert.ToDouble(pantalla.Text);
                op_pendiente = true;          }
            else
            {
                if (pantalla.Text == "0")
                {
                    DesactivarBotones();
                    pantalla.Text = "ERROR";

                }
                else
                {
                    pantalla.Text = Convert.ToString(operandoranterior);
                    Overflow();
                }

            }

        }

        //División, es la única que tiene excepción ya que tiene que controlar la división entre 0.

        private void tecladividir_Click(object sender, EventArgs e)
        {
            RealizaCalculos();
            operador = "/";
            primerdigito = false;

            if (op_pendiente == false)
            {  
                operandoranterior = Convert.ToDouble(pantalla.Text);
                op_pendiente = true;
            }
            else
            {
                if (pantalla.Text == "0")
                {
                    DesactivarBotones();
                    pantalla.Text = "ERROR";
                    
                }
                else
                {
                    pantalla.Text = Convert.ToString(operandoranterior);
                    Overflow();
                }

            }
        }


        // Metodo que realiza los calculos
        private void RealizaCalculos()
        {
            switch (operador)
            {
                case "+":
                    operandoranterior += Convert.ToDouble(pantalla.Text);
                    break;
                case "-":
                    operandoranterior -= Convert.ToDouble(pantalla.Text);
                    break;
                case "*":
                    operandoranterior *= Convert.ToDouble(pantalla.Text);
                    break;
                case "/":
                    operandoranterior /= Convert.ToDouble(pantalla.Text);
                    break;
            }
        }

        //Metodo para desactivar los botones.

        private void DesactivarBotones()
        {
            tecla0.Enabled = false;
            tecla1.Enabled = false;
            tecla2.Enabled = false;
            tecla3.Enabled = false;
            tecla4.Enabled = false;
            tecla5.Enabled = false;
            tecla6.Enabled = false;
            tecla7.Enabled = false;
            tecla8.Enabled = false;
            tecla9.Enabled = false;
            teclac.Enabled = false;
            tecladividir.Enabled = false;
            teclamasmenos.Enabled = false;
            teclamultiplicar.Enabled = false;
            teclapunto.Enabled = false;
            teclarestar.Enabled = false;
            teclaresultado.Enabled = false;
            teclasumar.Enabled = false;

            //Cuando hay error reiniciamos estas variables.
            op_pendiente = false;
            primerdigito = false;
        }

        //Metodo para activar botones.

        private void ActivarBotones()
        {
            tecla0.Enabled = true;
            tecla1.Enabled = true;
            tecla2.Enabled = true;
            tecla3.Enabled = true;
            tecla4.Enabled = true;
            tecla5.Enabled = true;
            tecla6.Enabled = true;
            tecla7.Enabled = true;
            tecla8.Enabled = true;
            tecla9.Enabled = true;
            teclac.Enabled = true;
            tecladividir.Enabled = true;
            teclamasmenos.Enabled = true;
            teclamultiplicar.Enabled = true;
            teclapunto.Enabled = true;
            teclarestar.Enabled = true;
            teclaresultado.Enabled = true;
            teclasumar.Enabled = true;
        }

        //Control del Overflow.

        private void Overflow()
        {
            int longitud = pantalla.Text.Length;
            if (longitud > maximo)
            {
                pantalla.Text = "OVERFLOW";
                DesactivarBotones();
                
            }
        }


        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }


        // Reiniciar calculadorra o encendido

        private void teclace_Click(object sender, EventArgs e)
        {
            if (tecla0.Enabled == false)
            {
                ActivarBotones();
            }
            
            pantalla.Text = "0";
            operandoranterior = Convert.ToDouble(pantalla.Text); // borra el operando anterior, para empezar de 0 con los calculos.
            op_pendiente = false;
            primerdigito = false;
        }

        
        // Borrar la pantalla

        private void teclac_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            primerdigito = false;
        }


        // Resultado

        private void teclaresultado_Click(object sender, EventArgs e)
        {
            
            if (operandoranterior != 0 && pantalla.Text == "0")
            {
                pantalla.Text = "ERROR";
                DesactivarBotones();
            }
            else
            {
                RealizaCalculos();
                pantalla.Text = Convert.ToString(operandoranterior);
                Overflow();
                op_pendiente = false;
                primerdigito = false;
            }

        }

        // Tecla punto, usamos Constains (contiene) para ver si contiene o no coma.

        private void teclapunto_Click(object sender, EventArgs e)
        {
            
            if (!pantalla.Text.Contains(","))
            {
                pantalla.Text += ",";

            }
           
        }


        // Acción más menos, su funcionamiento es simple, multiplicamos lo que hay en pantalla por -1.

        private void teclamasmenos_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains(","))
            {
                pantalla.Text = Convert.ToString(-1 * Convert.ToDouble(pantalla.Text));
            }
            else
            {
                pantalla.Text = Convert.ToString(-1 * Convert.ToDouble(pantalla.Text));
                pantalla.Text += ",";
            }
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
