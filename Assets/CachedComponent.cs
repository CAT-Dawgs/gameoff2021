using UnityEngine;

public class CachedComponent<T> where T : UnityEngine.Object {
    private T _cache;

    public void Clear()
    {
        _cache = null;
    }

    // Get the cached version of T, or look for it if no cached version exists
    public T Instance(MonoBehaviour container)
    {
        if (_cache == null)
        {
            var possibles = Object.FindObjectsOfType<T>();
            if (possibles.Length == 0)
            {
                Debug.LogError("No '" + typeof(T).Name + "' found when " + container.name + " searched for it.");
            }
            else
            {
                _cache = possibles[0];
                if (possibles.Length > 1)
                {
                    Debug.LogWarning("Multiple '" + typeof(T).Name + "' found when " + container.name + " searched. Using the first one.");
                }
            }
        }

        return _cache;
    }
}
