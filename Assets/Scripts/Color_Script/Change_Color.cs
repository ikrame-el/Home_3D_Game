using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Change_Color : MonoBehaviour, IPointerClickHandler
{
    GameObject current;
    public int i;
    int numBtn;

    public void OnPointerClick(PointerEventData eventData)
    {
        numBtn = BuutonClickColor.numButton;
        string str = this.name.Substring(0);
        //Debug.Log("str : " + str + " -- str.length : " + str.Length);
        i = int.Parse(this.name);
        current.GetComponent<MeshRenderer>().materials[numBtn].color = ColorManager.tabStockageMat[i].color;
    }

    void Update()
    {
        current = ObjectSelected.currentObject;
    }
}
