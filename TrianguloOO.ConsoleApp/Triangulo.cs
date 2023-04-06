using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOO.ConsoleApp
{
    internal class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;

        public bool FormarTriangulo()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool FormarEscaleno() 
        {
            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FormarIsoceles()
        {
            if (lado1 == lado2  || (lado1 ==lado3) || lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FormarEquilatero() 
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }


}
