using UnityEngine;
using Lncodes.Module.Unity.Template;
using Edu.Assignment.Ui.Navigation;

namespace Edu.Assignment.Ui.Core
{
    public sealed class GameManager : SingletonMonoBehavior<GameManager>
    {
        [field: SerializeField]
        public SceneNavigationController SceneNavigationController { get; private set; }

        private void Start() =>
            SceneNavigationController.NavigateToMainMenu();
    }
}