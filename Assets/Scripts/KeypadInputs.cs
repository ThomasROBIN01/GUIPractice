using UnityEngine;

public class KeypadInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            EventManager.cubertShrinkevent();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            EventManager.cubertGrowevent();
        }
    }
}
