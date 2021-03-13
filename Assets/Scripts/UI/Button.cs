using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public abstract class Button : MonoBehaviour
    {
        public void Press() => Action();

        protected abstract void Action();
    }
}
