﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDAapplicatie {
    public class Waarden {
        public int bestelnummer = 0;
        public List<Product> Bestelling = new List<Product>();
        public double Totaal = 0.00;
        public int Tafelnummer;
    }

    public struct Product {
        public int id;
        public double prijs;
    }
}
