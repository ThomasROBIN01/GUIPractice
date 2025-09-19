using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectionIndicatorMove : MonoBehaviour, ISelectHandler     // Inheriting ISelectHandler to be able to move the handle
{
    [SerializeField] RectTransform selectionIndicatorTransform;

    public void OnSelect(BaseEventData eventData)       // Pre selected and made code, to use ISelectHandler
    {
        RectTransform thisRectTransform = GetComponent<RectTransform>();

        selectionIndicatorTransform.position = new Vector3 (thisRectTransform.position.x, selectionIndicatorTransform.position.y, selectionIndicatorTransform.position.z);
    }

}
