﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex05
{
    public class PersonNameComparer : IComparer
    {
        public static IComparer Default = new PersonNameComparer();
        public int Compare(object x, object y)
        {
            if(x is Person && y is Person)
            {
                return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
            } else
            {
                throw new ArgumentException("One or both of these objects to compare is not a Person object.");
            }
        }
    }
}