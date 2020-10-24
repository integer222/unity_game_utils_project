using UnityEngine;

namespace Progstech.GameUtils.Singletons
{
    public abstract class AutoCreateSceneSingleton<T> : BaseSingleton where T : AutoCreateSceneSingleton<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    _instance = new GameObject().AddComponent<T>();
                }

                return _instance;
            }
        }

        protected sealed override void Awake()
        {
            base.Awake();
            if (_instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                PostAwake();
            }
        }

        protected abstract void PostAwake();
        
        protected virtual void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }
    }
}