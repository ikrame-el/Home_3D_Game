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
    public static GameObject currentRoom;
    public Button[] tabButton = new Button[8];
    Material[] tabMaterials;
    static int a = 0;
    GameObject temp = null;
    string currentName;
    int currentNameLength;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.collider.gameObject.tag != "unselectable" && hit.collider.gameObject.tag != null)
                {
                    currentObject = hit.collider.gameObject;
                    tabMaterials = currentObject.GetComponent<MeshRenderer>().materials;
                    for (int i = 0; i < tabMaterials.Length; i++)
                    {
                        tabButton[i].interactable = true;
                        tabButton[i].GetComponent<Image>().color = tabMaterials[i].color;
                    }

                    for (int i = tabMaterials.Length; i < tabButton.Length; i++)
                    {
                        tabButton[i].GetComponent<Image>().color = Color.white;
                        tabButton[i].interactable = false;
                    }

                    Debug.Log("currentObject.name: " + currentObject.name + " --  currentObject.tag : " + currentObject.tag);
                    temp = currentObject;
                    a++;

                    if (ObjectSelected.currentObject != null && ObjectSelected.currentObject.tag == "sol" || ObjectSelected.currentObject.tag == "mur1" || ObjectSelected.currentObject.tag == "mur2" || ObjectSelected.currentObject.tag == "mur3" || ObjectSelected.currentObject.tag == "mur4" || ObjectSelected.currentObject.tag == "mur5" || ObjectSelected.currentObject.tag == "mur6" || ObjectSelected.currentObject.tag == "mur7" || ObjectSelected.currentObject.tag == "mur8")
                    {
                        currentRoom = currentObject.transform.parent.gameObject;
                        Debug.Log("currentRoom.name: " + currentRoom.name + " --  currentRoom.tag : " + currentRoom.tag);
                    }
                    currentNameLength = currentObject.name.Length;

                    currentName = currentObject.name;

                }
            }
        }

        //recuperer tous les gameobject qui possede le script ActionObject
        ActionObject[] objects = GameObject.FindObjectsOfType<ActionObject>();

        MouseDrag[] ObjetcsMouseDrag = GameObject.FindObjectsOfType<MouseDrag>();
        //if (ObjectSelected.currentObject != null && ObjectSelected.currentObject.tag == "sol" || ObjectSelected.currentObject.tag == "mur1" || ObjectSelected.currentObject.tag == "mur2" || ObjectSelected.currentObject.tag == "mur3" || ObjectSelected.currentObject.tag == "mur4" || ObjectSelected.currentObject.tag == "mur5" || ObjectSelected.currentObject.tag == "mur6" || ObjectSelected.currentObject.tag == "mur7" || ObjectSelected.currentObject.tag == "mur8")
        //{
        //Debug.Log("currentName.Substring(0, 5) : " + currentName.Substring(0, 5));

        if (Change_3D_2D.camFPSActive)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].tag == "sol" || objects[i].tag == "mur1" || objects[i].tag == "mur2" || objects[i].tag == "mur3" || objects[i].tag == "mur4" || objects[i].tag == "mur5" || objects[i].tag == "mur6" || objects[i].tag == "mur7" || objects[i].tag == "mur8")
                {
                    objects[i].transform.GetComponent<BoxCollider>().enabled = false;
                }
                else
                {
                    objects[i].transform.GetComponent<MouseDrag>().enabled = false;

                    if (currentNameLength >= 5)
                    {
                        if (currentName.Substring(0, 5) == "porte")
                        {
                            objects[i].transform.GetComponent<BoxCollider>().enabled = false;
                        }
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].tag == "sol" || objects[i].tag == "mur1" || objects[i].tag == "mur2" || objects[i].tag == "mur3" || objects[i].tag == "mur4" || objects[i].tag == "mur5" || objects[i].tag == "mur6" || objects[i].tag == "mur7" || objects[i].tag == "mur8")
                {
                    objects[i].transform.GetComponent<BoxCollider>().enabled = true;
                }
                else
                {
                    objects[i].transform.GetComponent<MouseDrag>().enabled = true;
                    if (currentNameLength >= 5)
                    {
                        if (currentName.Substring(0, 5) == "porte")
                        {
                            objects[i].transform.GetComponent<BoxCollider>().enabled = true;
                        }
                    }
                }
            }
        }
        //}

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
