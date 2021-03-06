﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelected : MonoBehaviour
{
    public static GameObject currentObject;
    public Image[] tabImage = new Image[10];
    Material[] tabMaterials;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {

                currentObject = hit.collider.gameObject;
                Debug.Log("currentObject : " + currentObject.name);
                if (currentObject.tag == "Room")
                {
                    currentObject = CreateRoom.room.gameObject;
                    Debug.Log("currentObject : " + currentObject.name);
                }

                if (currentObject.name.Substring(0, 4) != "room")
                {
                    tabMaterials = currentObject.GetComponent<MeshRenderer>().materials;
                    for (int i = 0; i < tabMaterials.Length; i++)
                    {
                        Debug.Log("Material : " + tabMaterials[i].name);
                        tabImage[i].color = tabMaterials[i].color;

                    }
                }
            }
        }
    }
}
