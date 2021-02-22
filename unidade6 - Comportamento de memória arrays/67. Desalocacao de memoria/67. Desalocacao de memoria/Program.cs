
using System;

namespace _67._Desalocacao_de_memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Desalocação de memória - garbage collector e escopo local

            _Garbage Collector:____________
            Automatiza o gerenciamento de memória
            Monitora os objetos alocados (no heap) desalocando aqueles que 
            nao estao sendo ultilizados.
            
            Produto p1, p2;

            // o que estava aqui será desalocado pelo garbage collector em um momento futuro
            p1= new Produto ("Tv", 900.00, 0); 

            p2 = new Produto ("Mouse", 30.00, 0);
            p1 = p2;

            _Escopo Local:_________________________
             
            if(v >0){
                int y = 20;
            }

            O "y" deixa de existir imediatamente após passar pelo escopo.


             */
        }
    }
}
