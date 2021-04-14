using System;
using System.Collections.Generic;
using System.Text;

namespace _206.RestricoesGenerics.Services
{
    class CalculationService
    {
        //O generic pode ser em classe, metodo ou interface
        public T Max<T>(List<T> list) where T: IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0]; // salva o primeiro elemento
            for(int i =1; i< list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max  = list[i];
                }
            }
            return max;
        }


    }
}
