using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator
{
    public class Combinator : MonoBehaviour
    {
        List<char> _numbers = new List<char>();
        
        double _number;
        bool _isReset;

        public double GetNumber()
        {
            return _isReset ? _number : ParseNumbers();
        }

        double ParseNumbers()
        {
            var text = new System.Text.StringBuilder();
            foreach (var character in _numbers)
                text.Append(character);
            double result;
            double.TryParse(text.ToString(), out result);

            SetNumber(result);
            return result;
        }

        public bool TryPushNumber(char number)
        {
            if (number != '.' && (number < '0' || number > '9'))
                return false;

            _numbers.Add(number);
            _isReset = false;

            return true;
        }

        public void Clear()
        {
            _numbers.Clear();
        }

        public void SetNumber(double number)
        {
            _number = number;
            _isReset = true;
        }
    }
}