﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class MokaEspressoMaker : IExpressoMachine
    {
        private double _coffeeBeans;
        private double _water;

        public void AddCoffee()
        {
            // Adds 0.50 pounds of Costa Rican coffee
            _coffeeBeans += 0.50;
        }

        public void AddWater()
        {
            // Adds 500 mL of water
            _water += 0.5;
        }

        public void GetExpressoCoffee()
        {
            Console.WriteLine("Making Expresso Coffee");
        }
    }
}
