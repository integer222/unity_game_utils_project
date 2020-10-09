namespace Progstech.GameUtils.Singletons
{
    public class GameSingleton<T> : SceneSingleton<T> where T : GameSingleton<T>
    {
        protected override void PostAwake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}