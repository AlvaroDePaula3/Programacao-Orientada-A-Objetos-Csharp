using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_de_classe_em_C_
{
    internal class classeFilha :classeMae
    {

        public string sobrenomeCompleto = "Souza Maia";
        public string nomeDaFilha
        {
            get;
            set;
        }
        public void classeDaFilha()
        {
            Console.WriteLine(nomeDoPai);
            Console.WriteLine();
            classeDaMae();
            Console.WriteLine("Esta mensagem é da classe filha");
        }

        public classeFilha():base("Iniciando o console: ")
        {
            nomeDaFilha = "Jose";
        }
    }
}
