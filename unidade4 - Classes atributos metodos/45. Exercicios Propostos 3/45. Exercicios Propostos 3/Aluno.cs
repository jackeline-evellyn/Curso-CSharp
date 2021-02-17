using System;
using System.Collections.Generic;
using System.Text;

namespace _45._Exercicios_Propostos_3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double Soma()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado()
        {
            if (Soma() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else{
                return 60.0 - Soma();
            }
        }
    }
}
