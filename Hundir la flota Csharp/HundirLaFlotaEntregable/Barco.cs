using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundirLaFlotaEntregable
{
    class Barco
    {

        // Atributos indicados en el enunciado que han de estar en esta clase

        private int f;
        private int c;
        private Orientacion orientacion;
        private int tamanyo;
        private int tocadas;

        public Barco(int f, int c, Orientacion orientacion, int tamanyo)
        {
            this.f = f;
            this.c = c;
            this.orientacion = orientacion;
            this.tamanyo = tamanyo;
            this.tocadas = 0;

        }


        // Getters y setters necesarios para los atributos indicados en la descripción 
        
        public int GetF() { return f; }
        public int GetC() { return c; }
        public int GetTamanyo() { return tamanyo; }
        public int GetTocadas() { return tocadas; }
        public Orientacion GetOrientacion() { return orientacion; }

        // Método tocaBarco() que debe calcular lo que 
        //   se indica en el enunciado.

        public bool tocabarco()
        {
            tocadas += 1;
            if (tocadas == tamanyo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Método toString() que debe devolver un String con el
        //   contenido que se indica en el enunciado.

        public override string ToString() // 
        {
            return f + "#" + c + "#" + orientacion + "#" + tamanyo;
        }


    }
}
