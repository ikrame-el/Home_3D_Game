using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeScaleMur : MonoBehaviour
{
    public Text t1;
    public Text t2;

    private float posX;
    private float posY;
    private float posZ;

    private void Start()
    {
        posX = this.transform.position.x;
        posY = this.transform.position.y;
        posZ = this.transform.position.z;
    }

    float length;
    float width;

    GameObject mur1, mur2, mur3, mur4, sol;

    void Update()
    {
        length = float.Parse(t1.text);
        width = float.Parse(t2.text);

        if (Input.GetKeyDown(KeyCode.Return))
        {



            if (this.GetComponentInChildren<GameObject>().name == "mur_1")
            {
                mur1 = GetComponentsInChildren<GameObject>()[0];
            }
            if (this.GetComponentInChildren<GameObject>().name == "mur_2")
            {
                mur2 = GetComponentsInChildren<GameObject>()[1];
            }
            if (this.GetComponentInChildren<GameObject>().name == "mur_3")
            {
                mur3 = GetComponentsInChildren<GameObject>()[2];
            }
            if (this.GetComponentInChildren<GameObject>().name == "mur_4")
            {
                mur4 = GetComponentsInChildren<GameObject>()[3];
            }
            if (this.GetComponentInChildren<GameObject>().name == "sol_")
            {
                sol = GetComponentsInChildren<GameObject>()[4];
            }

            mur1.transform.localScale = new Vector3(length, 1, 1);
            mur2.transform.localScale = new Vector3(1, 1, width);
            mur3.transform.localScale = new Vector3(length, 1, 1);
            mur4.transform.localScale = new Vector3(1, 1, width);
            sol.transform.localScale = new Vector3(length,1, width);


            mur1.transform.transform.position = new Vector3(posX, posY, posZ * width);
            mur2.transform.position = new Vector3((5 * length) - 5, posY, posZ);
            mur3.transform.position = new Vector3(posX, posY, posZ * width);
            mur4.transform.position = new Vector3((5 * length) - 5, posY, posZ);
            //sol.transform.localScale = new Vector3(length, 1, width);


        }
    }
}
