using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Delete_Button : MonoBehaviour, IPointerClickHandler
{

    public ActionObject current_furniture;


    public void OnPointerClick(PointerEventData eventData)
    {
            current_furniture.DeleteObject();
    }

}
