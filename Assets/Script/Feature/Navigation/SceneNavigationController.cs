using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Edu.Assignment.Ui.Navigation
{
    [Serializable]
    public sealed class SceneNavigationController
    {
        [SerializeField]
        private Scenes _scenes = default;

        public void NavigateToSetting() =>
            SceneManager.LoadScene(_scenes.Setting);

        public void NavigateToMainMenu() =>
            SceneManager.LoadScene(_scenes.MainMenu);
    }
}