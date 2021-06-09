using Profile;
using Utility;
using UnityEngine;

public class GameController : BaseController
{
    internal GameController(PlayerProfile profilePlayer)
    {
        var leftMoveDiff = new SubscriptionProperty<float>();
        var rightMoveDiff = new SubscriptionProperty<float>();
        Debug.Log("dffd");

        //var tapeBackgroundController = new TapeBackgroundController(leftMoveDiff, rightMoveDiff);
        //AddController(tapeBackgroundController);

        //var inputGameController = new InputGameController(leftMoveDiff, rightMoveDiff, profilePlayer.CurrentCar);
        //AddController(inputGameController);

        //var carController = new CarController();
        //AddController(carController);
    }
}

