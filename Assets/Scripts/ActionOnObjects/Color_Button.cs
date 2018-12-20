using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Color_Button : MonoBehaviour, IPointerClickHandler
{
    public ActionObject current_f;

    public void OnPointerClick(PointerEventData eventData)
    {
        current_f.ColorButton();
    }
}
