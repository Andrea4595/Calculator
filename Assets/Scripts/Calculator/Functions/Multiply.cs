using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator.Functions
{
    public class Multiply : Function
    {
        public override double GetResult(double a, double b) => a * b;
    }
}