using Utility;

namespace Profile
{
    internal class PlayerProfile
    {
        internal PlayerProfile(float carSpeed)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(carSpeed);
        }

        public SubscriptionProperty<GameState> CurrentState { get; }
        public Car CurrentCar { get; }
    }
}
