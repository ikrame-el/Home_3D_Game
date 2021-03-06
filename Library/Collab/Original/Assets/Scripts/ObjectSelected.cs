﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelected : MonoBehaviour
{
    public Text textColor;
    public GameObject panelMenuColor;
    public GameObject panelColorPalette;
    public static GameObject currentObject;
    public Button[] tabButton = new Button[8];
    Material[] tabMaterials;

    BuutonClickColor buttonClickColor; 

    /*public void Change_material_current()
    {
        int numButton = buttonClickColor.Button_Pressed();

        switch (numButton)
        {
            case 0:  switch (numButton)
            {
                case 0 : 
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
        }
    }*/



    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.collider.gameObject.tag != "unselectable")
                {
                    currentObject = hit.collider.gameObject;
                    Debug.Log("currentObject : " + currentObject.name);
                    if (currentObject.tag == "Room")
                    {
                        currentObject = CreateRoom.room.gameObject;
                        // Debug.Log("currentObject : " + currentObject.name);
                    }

                    if (currentObject.name.Substring(0, 4) != "room")
                    {
                        tabMaterials = currentObject.GetComponent<MeshRenderer>().materials;
                        for (int i = 0; i < tabMaterials.Length; i++)
                        {
                            //Debug.Log("Material : " + tabMaterials[i].name);
                            //tabButton[i].color = tabMaterials[i].color;
                            tabButton[i].GetComponent<Image>().color = tabMaterials[i].color;
                        }
                    }
                }
            }
        }


        if (ActionObject.active)
        {
            for (int i = 0; i < tabButton.Length; i++)
            {
                tabButton[i].gameObject.SetActive(true);
            }
            Utils_.Active_Desactive_2(panelMenuColor, textColor.gameObject, true);
        }
        else
        {
            for (int i = 0; i < tabButton.Length; i++)
            {
                tabButton[i].gameObject.SetActive(false);
            }
            Utils_.Active_Desactive_2(panelMenuColor, textColor.gameObject, false);
        }

    }
}
