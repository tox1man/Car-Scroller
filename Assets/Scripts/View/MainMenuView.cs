using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

    public class MainMenuView : MonoBehaviour
    {
        [SerializeField]
        private Button _startGameButton;

        public void Init(UnityAction startGame)
        {
            _startGameButton.onClick.AddListener(startGame);
        }
        public void OnDestroy()
        {
            _startGameButton.onClick.RemoveAllListeners();
        }
    }
