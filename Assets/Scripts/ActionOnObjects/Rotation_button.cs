using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotation_button : MonoBehaviour, IPointerClickHandler
{

    public ActionObject current_f;

    public void OnPointerClick(PointerEventData eventData)
    {
        current_f.RotationObject();
    }



}
