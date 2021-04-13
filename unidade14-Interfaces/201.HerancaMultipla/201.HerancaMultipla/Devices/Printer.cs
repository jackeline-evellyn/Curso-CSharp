﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _201.HerancaMultipla.Devices
{
    class Printer: Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document); ;
        }
    }
}
