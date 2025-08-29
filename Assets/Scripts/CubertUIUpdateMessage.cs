using TMPro;
using UnityEngine;

public class CubertUIUpdateMessage : MonoBehaviour
{
    private TMP_Text messageDisplay;

    private string shrinkMessage = "Cubert shrank!";

    private string growMessage = "Cubert grew!";


    private void Start()
    {
        messageDisplay = GetComponent<TMP_Text>();

        EventManager.cubertShrinkevent += CubertShrinkMessage;
        EventManager.cubertGrowevent += CubertGrewMessage;
    }

    private void CubertGrewMessage ()
    {
        messageDisplay.text = growMessage;
    }

       private void CubertShrinkMessage()
    {
        messageDisplay.text = shrinkMessage;
    }

    private void OnDestroy()
    {
        EventManager.cubertShrinkevent -= CubertShrinkMessage;
        EventManager.cubertGrowevent -= CubertGrewMessage;
    }

}
