using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_classes_em_C_
{
    internal class Program
    {
        //classe pública com elementos privados
        public class contaDoJogo
        {
            private string NomeDoJogador;
            private string Senha;
            private double dinheiroDaConta;

            public double comprarPersonagem(double PrecoDoPersonagem, string SenhaDoJogador)
            {
                if (Senha == SenhaDoJogador)
                {
                    if ( PrecoDoPersonagem < dinheiroDaConta)
                    {
                        dinheiroDaConta -= PrecoDoPersonagem;
                        Console.WriteLine("Personagem comprado com sucesso, o valor gasto foi de: " + PrecoDoPersonagem + " ");
                        return PrecoDoPersonagem;
                    } 
                    else
                    {
                        Console.WriteLine("Saldo insuficiente, por favor tente novamente quando tiver mais créditos. Créditos atuais: " + dinheiroDaConta);
                        return 0;
                    }
                } 
                else
                {
                    Console.WriteLine("Senha incorreta, por favor verifique sua senha e tente novamente.");
                    return 0;
                }
            }
            public void colocarDinheiro(double dinheiroPago)
            {
                dinheiroDaConta += dinheiroPago;
                Console.WriteLine("Parabéns, o valor de " + dinheiroPago + " foi depositado com sucesso");
            }

            public void verDinheiro(string senhaDoJogador)
            {
                if (Senha == senhaDoJogador)
                {
                    Console.WriteLine(" O saldo é de " + dinheiroDaConta);
                }
                else
                {
                    Console.WriteLine("Senha incorreta, por favor verifique sua senha e tente novamente.");
                }
            }
            //método construtor
            // lembre-se que o constutor sempre é um método público (public)
            // É o primeiro método a ser declarado na depuração e ele não possui um parâmetro de saída
            // Ele é usado normalmente pra executar as configurações iniciais dos nossos projetos
            // podemos ter quantos construtores nós quisermos
            public contaDoJogo(string realSenha, string nomeJogador)
            {
                dinheiroDaConta = 0;
                realSenha = Senha;
                nomeJogador = NomeDoJogador;
            }
        }

        static void Main(string[] args)
        {
            contaDoJogo noobMaster69 = new contaDoJogo("246810", "Ana_Flavia");

            noobMaster69.comprarPersonagem(2000, "246810");
            noobMaster69.colocarDinheiro(5000);
            noobMaster69.verDinheiro("246810");

            Console.ReadKey();
        }
    }
}
