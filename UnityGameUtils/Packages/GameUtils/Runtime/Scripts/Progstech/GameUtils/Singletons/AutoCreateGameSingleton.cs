namespace Progstech.GameUtils.Singletons
{
    public class AutoCreateGameSingleton<T> : AutoCreateSceneSingleton<T> where T : AutoCreateGameSingleton<T>
    {
        protected override void PostAwake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}