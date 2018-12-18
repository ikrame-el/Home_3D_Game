using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    float distance = 0.1f;
    GameObject current_;

    void OnMouseDrag()
    {
        current_ = ObjectSelected.currentObject;
        if (!Change_3D_2D.camFPSActive)
        {

            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 FurniturePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            if (ObjectSelected.currentObject.tag == "sol" || ObjectSelected.currentObject.tag == "mur1" || ObjectSelected.currentObject.tag == "mur2" || ObjectSelected.currentObject.tag == "mur3" || ObjectSelected.currentObject.tag == "mur4" || ObjectSelected.currentObject.tag == "mur5" || ObjectSelected.currentObject.tag == "mur6" || ObjectSelected.currentObject.tag == "mur7" || ObjectSelected.currentObject.tag == "mur8")
            {
                Debug.Log("DragDragDrag---- Room");
                ObjectSelected.currentRoom.transform.position = new Vector3(FurniturePosition.x, ObjectSelected.currentObject.transform.localPosition.y, FurniturePosition.z);
            }
            else
            {
                ObjectSelected.currentObject.transform.position = new Vector3(FurniturePosition.x, ObjectSelected.currentObject.transform.localPosition.y, FurniturePosition.z);
            }
        }
    }
}
