﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CSharp.Aula132.Exercicio01.Entities
{
    internal class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
