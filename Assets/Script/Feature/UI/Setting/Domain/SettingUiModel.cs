using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public sealed class SettingUiModel
{
    [SerializeField]
    internal Slider SliderSfx = default;

    [SerializeField]
    internal Toggle ToggleMute = default;

    [SerializeField]
    internal Button BtnConsole = default;

    [SerializeField]
    internal Button BtnBackToMainMenu = default;

    [SerializeField]
    internal TMP_Dropdown DropdownResolution = default;
}
