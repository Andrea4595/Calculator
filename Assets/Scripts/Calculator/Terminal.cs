using Calculator.Functions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator
{
    public class Terminal : MonoBehaviour
    {
        [SerializeField]
        TMPro.TextMeshProUGUI _terminalText;

        [SerializeField]
        Combinator _combinator;

        Function _function;
        double _previous = 0;

        public void PushNumber(char number)
        {
            _combinator.TryPushNumber(number);
            SetTerminal(_combinator.GetNumber().ToString());
        }

        public void PushFunction(Function function)
        {
            RunPreviousFunction();
            _function = function;
            _previous = _combinator.GetNumber();
            _combinator.Clear();
        }

        public void PushEqual()
        {
            RunPreviousFunction();
            _function = null;
            _previous = 0;
            _combinator.Clear();
        }

        void RunPreviousFunction()
        {
            if (_function == null)
                return;

            var result = _function.GetResult(_previous, _combinator.GetNumber());
            SetTerminal(result.ToString());
            _combinator.SetNumber(result);
        }

        void SetTerminal(string text)
        {
            _terminalText.text = text;
        }

        public void Clear()
        {
            _combinator.Clear();
            _function = null;
            _previous = 0;
            SetTerminal("");
        }
    }
}