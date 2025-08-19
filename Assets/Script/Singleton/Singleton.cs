using UnityEngine;


// Generic Singleton class for Unity MonoBehaviour
// This class ensures that only one instance of the specified MonoBehaviour type exists in the scene.
namespace Singleton.Generic
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = GetComponent<T>();
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
