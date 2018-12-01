using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionCamera : MonoBehaviour
{

    public void MoveUp()
    { 
        transform.position += new Vector3(0, 0, -1);
    }

    public void MoveRight()
    {
        transform.position += new Vector3(-1, 0, 0);
    }
    public void MoveDown()
    {
        transform.position += new Vector3(0, 0, 1);
    }
    public void MoveLeft()
    {
        transform.position += new Vector3(1, 0, 0);
    }

}
