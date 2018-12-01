using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    void OnMouseDrag()
    {
    //coucou j'ai ete modifier sur bitbucket
        Debug.Log("dragDragDrag");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,0 ,Input.mousePosition.y);
        transform.position = mousePosition/100;
    }

}
