using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador
{
    internal class Interface
    {
        //atributos
        private Elevador elevador;

        //construtor

        public Interface () 
        {
            int andares, capacidade;
            Console.WriteLine("Informe a quantidade de andares do predio:");
            andares = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a capacidade do elevador");
            capacidade = int.Parse(Console.ReadLine());
            elevador = new Elevador(andares, capacidade);
        }
        //método
        
        public void usar_elevador ()
        {
            int opcao = 1;
            while (opcao != 0){
                Console.WriteLine("Informe a opcao desejada:");
                Console.WriteLine("1 Entrar no elevador:");
                Console.WriteLine("2 Sair do elevador:");
                Console.WriteLine("3 Subir um andar:");
                Console.WriteLine("4 Descer um andar:");
                Console.WriteLine("0 Sair do programa:");

                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        elevador.entrar();
                        break;

                    case 2:
                        elevador.sair();
                        break;

                    case 3:
                        elevador.subir();
                        break;

                    case 4:
                        elevador.descer();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por utilizar o elevador");
                        break;

                    default:
                        Console.WriteLine("Opçao invalida");
                        break;

                }
             
            }
        }

    }
}
