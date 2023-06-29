using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_de_classe_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            classeFilha filha = new classeFilha();
            Console.WriteLine(filha.propriedadeDoConstrutor);
            filha.classeDaFilha();
            Console.WriteLine(filha.sobrenomeCompleto);
            Console.ReadKey();
        }
    }
}
