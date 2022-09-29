﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex01
{
    public class MyClass
    {
        public readonly string Name;

        private int intVal;

        public int Val
        {
            get { return intVal; }

            set
            {
                if(value >= 0 && value <= 10)
                {
                    intVal = value;
                } else
                {
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value from 0 to 10."));
                }
            }

        }

        public override string ToString() => "Name: " + Name + "\nVal: " + Val;

        private MyClass() : this("Default Name") { }

        public MyClass(string newName)
        {
            Name = newName; 
            intVal = 0;
        }

        private int MyDoubledInt = 5;

        public int MyDoubledIntProp => (MyDoubledInt * 2);
        
    }
}
