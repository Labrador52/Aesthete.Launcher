using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aestehte.UniLauncher
{
    public abstract class LaunchTask : ScriptableObject
    {
        public abstract void Execute();
    }
}