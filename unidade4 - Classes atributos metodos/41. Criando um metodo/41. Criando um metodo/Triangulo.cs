using System;
using System.Collections.Generic;
using System.Text;

namespace _41._Criando_um_metodo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //o metodo fica dentro da classe
        //o metodo nada mais é que uma funcao dentro da classe

        public double Area() // dentro dos paranteses os parametros de entrada
        {
            //aqui fica toda a logica de calcular a area
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p-A) *(p-B) * (p-C));
            // return raiz;
        }
    }
}
