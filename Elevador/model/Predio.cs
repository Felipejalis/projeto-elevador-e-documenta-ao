using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador
{
    internal class Predio
    {
        //atributos 
        private int andares;

        //contrutor
        public Predio()
        {
            andares = 0;
        }

        //métodos
        public int get_andares()
        {
            return andares;
        }

        public void set_andares(int andares)
        {
            this.andares = andares;
        }


    }
}
