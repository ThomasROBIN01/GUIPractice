using UnityEngine;

public class CubertBigorSmall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventManager.cubertShrinkevent += ShrinkCubert;
        EventManager.cubertGrowevent += GrowCubert;
    }

    private void ShrinkCubert()
    {
        gameObject.transform.localScale = transform.localScale / 2;
    }

    private void GrowCubert()
    {
        transform.localScale *= 2;
    }

    private void OnDestroy()    // This is to unsubscribe the object to the event
    {
        EventManager.cubertShrinkevent -= ShrinkCubert;
        EventManager.cubertGrowevent -= GrowCubert;
    }

}
