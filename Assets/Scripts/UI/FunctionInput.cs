using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class FunctionInput : Button
    {
        [SerializeField]
        Calculator.Terminal _terminal;
        [SerializeField]
        Calculator.Functions.Function _function;

        protected override void Action()
        {
            _terminal.PushFunction(_function);
        }
    }
}