using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class NumberInput : Button
    {
        [SerializeField]
        char _number;
        [SerializeField]
        Calculator.Terminal _terminal;

        protected override void Action() => _terminal.PushNumber(_number);
    }
}