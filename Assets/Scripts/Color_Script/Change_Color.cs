using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Change_Color : MonoBehaviour, IPointerClickHandler
{

    GameObject current = ObjectSelected.currentObject;
    public int i;
    ColorManager colo;
    BuutonClickColor btnClickColor;
    int numBtn;

    public void OnPointerClick(PointerEventData eventData)
    {
        numBtn = btnClickColor.numButton;

        Debug.Log("this : " + this);
        int a = name.Length - 7;
        int b = name.Length - 1;
        //Debug.Log("a: " + a + " - b : " + b);

        //string str = this.name.Substring(a , b );
        //Debug.Log ("str : " + str +" -- str.length : " + str.Length);

        Debug.Log("ChangerCouleurClick -- " + "current object : " + current.name );
        i = int.Parse(this.name);


        current.GetComponent<MeshRenderer>().materials[numBtn] = ColorManager.tabStockageMat[i];
    }
}
