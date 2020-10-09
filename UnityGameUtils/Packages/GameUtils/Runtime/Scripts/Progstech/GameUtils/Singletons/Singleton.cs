namespace Progstech.GameUtils.Singletons
{
    public class Singleton<T> where T : new()
    {
        public static readonly T Instance = new T();
    }
}
