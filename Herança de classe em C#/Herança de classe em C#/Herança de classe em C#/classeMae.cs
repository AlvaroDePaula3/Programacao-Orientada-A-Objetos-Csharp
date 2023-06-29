using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_de_classe_em_C_
{
    internal class classeMae
    {
        protected string nomeDoPai = "Carlos";
        public string sobrenomeDaMae = "souza";
        public int numeroDeFilhos = 2;
        public string nomeDaMae
        {
            get;
            set;
        }

        public string propriedadeDoConstrutor
        {
            get;
            set;
        }

        public void classeDaMae()
        {

            Console.WriteLine("Essa mensagem é da classe mãe");
        }

        public classeMae(string parametroMae)
        {
            nomeDaMae = "Ana";
            propriedadeDoConstrutor = parametroMae;
        }
    }
}
