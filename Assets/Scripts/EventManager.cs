using UnityEngine;

public class EventManager : MonoBehaviour
{
    // This means there can be only of this in the whole game and that anything using .instance is refering to this:

    public static EventManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Only one eventmanager script should be attached to an object in the scene!");
            gameObject.SetActive(false);
        }
    }

    public delegate void CubertShrink();    // delegate 
    public static CubertShrink cubertShrinkevent;

    public delegate void CubertGrow();
    public static CubertShrink cubertGrowevent;

}
