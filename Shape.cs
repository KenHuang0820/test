using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw7
{
    class Shape
    {
        protected double length1;
        protected double length2;
        protected double density;
        protected double pi = 3.1415926;
        protected static int amount = 0;
        public static int Amount
        {
            get { return amount; }
        }

        public Shape(double length, double density)
        {
            this.length1 = length;
            this.density = density;
            amount++;
        }
        public Shape(double length1, double length2, double density)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.density = density;
            amount++;
        }
        public virtual double WorkVolume() 
        { 
            return 0; 
        }
        public virtual string GetName() 
        { 
            return ""; 
        }
        public double WorkQuality() 
        { 
            return WorkVolume() * density; 
        }
        public string Show()
        {
            string str="";
            str += GetName()+"\t";
            str += length1 + "\t" + length2 + "\t";
            str += density + "\t";
            str += WorkVolume() + "\t";
            str += WorkQuality() + "\n";
            return str;
        }
    }
}

