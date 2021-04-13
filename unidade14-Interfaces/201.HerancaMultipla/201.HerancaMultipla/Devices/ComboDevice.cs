using System;

namespace _201.HerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevide print: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevide processing: " + document);
        }

        public string Scan()
        {
           return "ComboDevide scan result";
        }
    }
}
