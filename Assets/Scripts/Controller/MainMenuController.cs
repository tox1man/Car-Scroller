using Profile;
using UnityEngine;
using Utility;
    internal class MainMenuController : BaseController
    {
        private readonly PlayerProfile _playerProfile;
        private MainMenuView _view;
        private readonly ResourcePath _viewPath = new ResourcePath { Path = "Prefabs/MainMenu" };

        public MainMenuController(Transform UIPosition, PlayerProfile playerProfile)
        {
            _playerProfile = playerProfile;
            _view = LoadView(UIPosition);
            _view.Init(StartGame);
        }

        private MainMenuView LoadView(Transform UIPosition)
        {
            GameObject objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath), UIPosition, false);
            AddGameObject(objectView);
            return objectView.GetComponent<MainMenuView>();
        }

        private void StartGame()
        {
            _playerProfile.CurrentState.Value = GameState.Game;
        }
    }
