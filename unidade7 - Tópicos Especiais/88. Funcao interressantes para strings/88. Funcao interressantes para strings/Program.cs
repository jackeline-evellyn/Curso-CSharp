using System;

namespace _88._Funcao_interressantes_para_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "  abcde FGHIJ ABC abc DEFG     ";
           
            //Função para deixar todos maiusculos
            string s1 = original.ToUpper();

            //Função para transformar em minusculo
            string s2 = original.ToLower();

            //Apaga os espaços em branco antes e depois  a string
            string s3 = original.Trim();

            //___________________________

            //Busca na string a primeira apariçao
            int n1 = original.IndexOf("bc");

            //Busca a última ocorrência
            int n2 = original.LastIndexOf("bc");

            //Recortar uma string
            string s4 = original.Substring(3); // Corta a parti da posicao 3
            string s5 = original.Substring(3, 5); //Corta 5 caracteres

            //Substituir uma parte da string por outra
            //Ex substitui todo caractere <a> por <x>
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc","xy");

            //Testar se é uma string é nula ou vazia
            bool b1 = String.IsNullOrEmpty(original);

            //Testa se é nula ou espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original:  - " + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3  + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4 + "-"); 
            Console.WriteLine("Substring(3, 5): " + s5 + "-");
            Console.WriteLine("Replace('a','x': -" + s6 + "-");
            Console.WriteLine("Replace('abc','xy': -" + s7 +"-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: "+b2);
        }
    }
}
