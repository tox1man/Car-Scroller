using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    internal class MainMenuView : MonoBehaviour
    {
        [SerializeField]
        private Button _startGameButton;

        public void Init(UnityAction startGame)
        {
            _startGameButton.onClick.AddListener(startGame);
            Debug.Log("start");
        }
        public void OnDestroy()
        {
            _startGameButton.onClick.RemoveAllListeners();
        }
    }
}
