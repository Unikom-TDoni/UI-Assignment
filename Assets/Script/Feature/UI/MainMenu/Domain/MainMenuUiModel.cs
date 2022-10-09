using System;
using UnityEngine;
using UnityEngine.UI;

namespace Edu.Assignment.UI
{
    [Serializable]
    internal sealed class MainMenuUiModel
    {
        [SerializeField]
        internal Button BtnExit = default;

        [SerializeField]
        internal Button BtnSetting = default;
    }
}
