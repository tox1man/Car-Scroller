using Utility;

namespace Profile
{
    public class PlayerProfile
    {
        public PlayerProfile(float carSpeed)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(carSpeed);
        }

        public SubscriptionProperty<GameState> CurrentState { get; }
        public Car CurrentCar { get; }
    }
}
