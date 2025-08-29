using TMPro;
using UnityEngine;

public class SizeScore : MonoBehaviour
{
    int growScore;
    int shrinkScore;

    private TMP_Text scoreDisplay;

    private void Start()
    {
        scoreDisplay = GetComponent<TMP_Text>();

        EventManager.cubertShrinkevent += IncreaseShrinkScore;
        EventManager.cubertGrowevent += IncreaseGrowScore;
    }

    private void IncreaseGrowScore()
    {
        growScore += growScore;

    }

    private void IncreaseShrinkScore()
    {
        shrinkScore += shrinkScore;
    }

    private void OnDestroy()    // This is to unsubscribe the object to the event
    {
        EventManager.cubertShrinkevent -= IncreaseShrinkScore;
        EventManager.cubertGrowevent -= IncreaseGrowScore;
    }

}
