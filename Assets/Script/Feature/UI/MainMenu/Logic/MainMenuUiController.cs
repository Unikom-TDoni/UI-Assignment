using Edu.Assignment.Ui.Core;
using UnityEngine;

namespace Edu.Assignment.UI
{
    public sealed class MainMenuUiController : MonoBehaviour
    {
        [SerializeField]
        private MainMenuUiModel _uiModel = default;

        private void Awake()
        {
            _uiModel.BtnExit.onClick.AddListener(() => Application.Quit());

            _uiModel.BtnSetting.onClick.AddListener(() =>
                GameManager.Instance.SceneNavigationController.NavigateToSetting()
            );
        }
    }
}