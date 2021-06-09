using Profile;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField]
    private Transform _UIPosition;
    private MainController _mainController;

    private void Awake()
    {
        var profilePlayer = new PlayerProfile(15f);
        profilePlayer.CurrentState.Value = GameState.MainMenu;
        _mainController = new MainController(_UIPosition, profilePlayer);
    }

    protected void OnDestroy()
    {
        _mainController?.Dispose();
    }
}