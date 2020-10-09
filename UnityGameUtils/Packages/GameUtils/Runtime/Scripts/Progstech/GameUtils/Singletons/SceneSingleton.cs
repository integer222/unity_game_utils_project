using UnityEngine;

namespace Progstech.GameUtils.Singletons
{
    public abstract class SceneSingleton<T> : BaseSingleton where T : SceneSingleton<T> {

        public static T Instance { get; private set; }

        public static bool InstanceExists => Instance != null;

        protected sealed override void Awake()
        {
            if (InstanceExists)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = (T)this;
                PostAwake();
            }
        }

        protected abstract void PostAwake();


        protected virtual void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
}