using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    float distance = 1;

    void OnMouseDrag()
    {
        //Debug.Log("dragDragDrag");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

        Vector3 FurniturePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        ObjectSelected.currentObject.transform.position = new Vector3 ( FurniturePosition.x, ObjectSelected.currentObject.transform.localPosition.y, FurniturePosition.z);

    }

}
