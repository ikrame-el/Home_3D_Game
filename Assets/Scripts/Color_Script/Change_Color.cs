using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Change_Color : MonoBehaviour, IPointerClickHandler
{

    GameObject current;
    public int i;
    ColorManager colo;
    int numBtn;

   //------ GameObject[] tabCurrent = new GameObject[ObjectSelected.currentObject.transform.childCount];

    public void OnPointerClick(PointerEventData eventData)
    {
        numBtn = BuutonClickColor.numButton;

        //Debug.Log("this : " + this);
        int a = name.Length - 7;
        int b = name.Length - 1;
        //Debug.Log("a: " + a + " - b : " + b);

        string str = this.name.Substring(0);
        Debug.Log("str : " + str + " -- str.length : " + str.Length);

        //Debug.Log("ChangerCouleurClick -- " + "current object : " + current.name );
        i = int.Parse(this.name);

        //Debug.Log("numBtn : " + numBtn);
        current.GetComponent<MeshRenderer>().materials[numBtn].color = ColorManager.tabStockageMat[i].color;
        //----tabCurrent[i].GetComponent<MeshRenderer>().materials[numBtn].color = ColorManager.tabStockageMat[i].color;
    }

    void Update()
    {
        if (ObjectSelected.currentObject.tag == "sol" || ObjectSelected.currentObject.tag == "mur1" || ObjectSelected.currentObject.tag == "mur2" || ObjectSelected.currentObject.tag == "mur3" || ObjectSelected.currentObject.tag == "mur4" || ObjectSelected.currentObject.tag == "mur5" || ObjectSelected.currentObject.tag == "mur6" || ObjectSelected.currentObject.tag == "mur7" || ObjectSelected.currentObject.tag == "mur8")
        {
           current = ObjectSelected.partieRoom;
        }
        else
        {
        current = ObjectSelected.currentObject;
        }
    }
}
