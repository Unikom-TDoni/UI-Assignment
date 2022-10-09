using System;
using UnityEngine;
using Lncodes.Module.Unity.Editor;

namespace Edu.Assignment.Ui.Navigation
{
    [Serializable]
    internal sealed class Scenes
    {
        [field: SerializeField]
        internal SceneObject MainMenu { get; private set; }

        [field: SerializeField]
        internal SceneObject Setting { get; private set; }
    }
}
