using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator.Functions
{
    public abstract class Function : MonoBehaviour
    {
        public abstract double GetResult(double a, double b);
    }
}