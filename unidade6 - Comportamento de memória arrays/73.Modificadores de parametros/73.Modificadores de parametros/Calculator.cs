using System;
using System.Collections.Generic;
using System.Text;

namespace _73.Modificadores_de_parametros
{
    class Calculator
    {
        //quando se usa ref mecherá na variavel original
        //faz o parametro ser uma referencia a variavel original
        public static void Triple (ref int x)
        {
            x = x * 3;
        }

        //Out é onde é guardado o resultado 
        public static void Triplo (int origin, out int result)
        {
            result = origin * 3;
        }

         
    }
}
