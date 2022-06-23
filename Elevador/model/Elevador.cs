using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador
{
    internal class Elevador
    {
        //atributos
        private Predio predio;
        private int andar;
        private int capacidade;
        private int lotacao;

        //construtor
        public Elevador(int andares, int capacidade)
        {
            predio = new Predio();
            predio.set_andares(andares);
            this.capacidade = capacidade;
            lotacao = 0;
        }

        //metodos
        public void entrar()
        {
            if (lotacao < capacidade)
            {
                lotacao = lotacao + 1;
                status();
            }

            else
            {
                Console.WriteLine("0 elevador esta lotado");
            }

        }

        public void sair()
        {
            if (lotacao > 0)
            {
                lotacao = lotacao - 1;
                status();
            }
            else
            {
                Console.WriteLine("o elevador esta vazio");
            }
        }

        public void subir()
        {
            if (andar < predio.get_andares())
            {
                andar = andar + 1;
                status();
            }
            else
            {
                Console.WriteLine("O elevador ja esta no ultimo andar");
            }
        }

        public void descer ()
        {
            if (andar > 0)
            {
                andar = andar - 1;
                status();
            }
            else
            {
                Console.WriteLine("O elevador esta no terreo");
            }
        }

        public void status()
        {
            Console.WriteLine("andar  : " + andar) ;
            Console.WriteLine("Lotação: " + lotacao);
            Console.WriteLine("...................");

        }






    }
}
