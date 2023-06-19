using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_Da_Classe_Em_Csharp
{
    public class estilosDeMusica
    {
        public string nomeDoArtista;
        private double minutosDaMusica;
        private bool musicaTocando = false;

        public void avancarMinutos(double minutoFinal)
        {
            minutosDaMusica = minutoFinal;
            nomeDoArtista = "Chilled Cow";
        }

        public bool aperteOPlay
        {
            get { return musicaTocando; }
            set { musicaTocando = value; }
        }

        public double ControlarMusica
        {
            get { return minutosDaMusica; }
            set
            {
                if (aperteOPlay)
                    minutosDaMusica = value;
            }
        }
        //criarei uma propriedade sem o atributo, porém não é muito recomendado. Farei aqui só para fins de estudo mesmo.

        public string estiloDoCantor
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            estilosDeMusica Musica = new estilosDeMusica();
            Musica.nomeDoArtista = "Justim Timberlake";

            Musica.aperteOPlay = true;
            Musica.ControlarMusica = 2;
            Musica.aperteOPlay = false;

            // propriedade sem atributo
            Musica.estiloDoCantor = "pop";
        }
    }
}

