﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerenciaCS_ManchaTerán
{
    class Punto2D : Punto
    {
        protected double y;

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Punto2D()
        {

            y = 0;
        }

        public Punto2D(double x, double y)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return base.ToString() + " Y= " + y;
        }
    }
}
