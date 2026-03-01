using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static GlobalInfo Instance;

    public string catName;
    public string dogName;
    public string chickenName;
    private void Awake()
    {
        // start of a new code. Destroy if the code wants to create a new instance if one already exists

        if (Instance != null)
        {

            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
