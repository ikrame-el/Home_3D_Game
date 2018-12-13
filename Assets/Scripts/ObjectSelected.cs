using System.Collections;
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

    static int a = 0;

    GameObject temp = null;
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
                    tabMaterials = currentObject.GetComponent<MeshRenderer>().materials;
                    if (currentObject.tag == "sol" || ObjectSelected.currentObject.tag == "mur1" || ObjectSelected.currentObject.tag == "mur2" || ObjectSelected.currentObject.tag == "mur3" || ObjectSelected.currentObject.tag == "mur4" || ObjectSelected.currentObject.tag == "mur5" || ObjectSelected.currentObject.tag == "mur6" || ObjectSelected.currentObject.tag == "mur7" || ObjectSelected.currentObject.tag == "mur8")
                    {
                        currentObject = currentObject.transform.parent.gameObject;
                    }
                    else
                    {
                        //tabMaterials = currentObject.GetComponent<MeshRenderer>().materials;

                        for (int i = 0; i < tabMaterials.Length; i++)
                        {
                            //Debug.Log("Material : " + tabMaterials[i].name);
                            //tabButton[i].color = tabMaterials[i].color;
                            tabButton[i].interactable = true;
                            tabButton[i].GetComponent<Image>().color = tabMaterials[i].color;
                        }

                        for (int i = tabMaterials.Length; i < tabButton.Length; i++)
                        {
                            tabButton[i].GetComponent<Image>().color = Color.white;
                            tabButton[i].interactable = false;
                        }
                    }

                    Debug.Log("currentObject.name: " + currentObject.name + " --  currentObject.tag : " + currentObject.tag);
                    temp = currentObject;
                    a++;
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

        //if (Input.GetMouseButtonDown(1))
        //{
        //    currentObject = null;
        //}

    }
}
