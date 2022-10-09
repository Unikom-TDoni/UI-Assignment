using Edu.Assignment.Ui.Core;
using UnityEngine;

namespace Edu.Assignment.UI
{
    public sealed class SettingUiController : MonoBehaviour
    {
        [SerializeField]
        private SettingUiModel _uiModel = default;

        private void Awake()
        {
            _uiModel.BtnConsole.onClick.AddListener(() =>
            {
                Debug.Log($"Sfx slider value = {_uiModel.SliderSfx.value}");
                Debug.Log($"Mute toggle value = {_uiModel.ToggleMute.isOn}");
                Debug.Log($"Resolution dropdown value = {_uiModel.DropdownResolution.options[_uiModel.DropdownResolution.value].text}");
            });

            _uiModel.BtnBackToMainMenu.onClick.AddListener(() =>
                GameManager.Instance.SceneNavigationController.NavigateToMainMenu()
            );
        }
    }
}