using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator.Functions
{
    public class Divide : Function
    {
        public override double GetResult(double a, double b)
        {
            if (b == 0)
                return Mathf.Infinity;

            return a / b;
        }
    }
}