﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie = new Cookie();

            Console.WriteLine("Please enter a name for a cookie");
            string name = Console.ReadLine();

            cookie.Name = name;

        }
    }
}
