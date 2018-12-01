using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviour
{
    public Button Button_create_room;
    //les mesure de la piece
    public Text inputWidth;
    public Text inputLength;

    float width;
    float length;

    GameObject mur1;
    GameObject mur2;
    GameObject mur3;
    GameObject mur4;
    GameObject mur5;
    GameObject mur6;
    GameObject mur7;
    GameObject mur8;
    GameObject sol;

    GameObject mur1_;
    GameObject mur2_;
    GameObject mur3_;
    GameObject mur4_;
    GameObject mur5_;
    GameObject mur6_;
    GameObject mur7_;
    GameObject mur8_;
    GameObject sol_;


    bool isPressed = false;

    public void Create_Room()
    {
        if (inputLength.text != "" && inputWidth.text != "")
        {
            width = float.Parse((inputWidth.text));
            length = float.Parse((inputLength.text));
        }

        isPressed = true;
        //creation du sol de la piece
        sol = Resources.Load("Rooms/solPrefab") as GameObject;
        sol_ = Instantiate(sol);
        sol_.transform.localScale = new Vector3(sol.transform.localScale.x / 10 * width, 1, sol.transform.localScale.z / 10 * length);


        //creation des mur interieur de la piece
        //OK
        mur1 = Resources.Load("Rooms/mur1") as GameObject;
        mur1_ = Instantiate(mur1);
        mur1_.name = "mur1";
        mur1_.transform.localPosition = new Vector3(0, 3, length/2 + .1f);
        mur1_.transform.localScale = new Vector3(mur1.transform.localScale.x  * width, 6, 0.2f);

        //scale ok
        mur2 = Resources.Load("Rooms/mur2") as GameObject;
        mur2_ = Instantiate(mur2);
        mur2_.name = "mur2";
        mur2_.transform.localPosition = new Vector3(width/2 + 0.1f, 3, 0);
        mur2_.transform.localScale = new Vector3(0.2f, 6, length + 0.8f);
        
        //OK
        mur3 = Resources.Load("Rooms/mur3") as GameObject;
        mur3_ = Instantiate(mur3);
        mur3_.name = "mur3";
        mur3_.transform.localPosition = new Vector3(0, 3, - length/2 - .1f );
        mur3_.transform.localScale = mur1_.transform.localScale;

        mur4 = Resources.Load("Rooms/mur4") as GameObject;
        mur4_ = Instantiate(mur4);
        mur4_.name = "mur4";
        mur4_.transform.localPosition = new Vector3(- width/2 - .1f, 3, 0);
        mur4_.transform.localScale = mur2_.transform.localScale;

        //creation des mur exterieur de la piece
        mur5 = Resources.Load("Rooms/mur5") as GameObject;
        mur5_ = Instantiate(mur5);
        mur5_.name = "mur5";
        mur5_.transform.localPosition = new Vector3(0, 3, mur1_.transform.localPosition.z+0.2f);
        mur5_.transform.localScale = mur1_.transform.localScale;

        mur6 = Resources.Load("Rooms/mur6") as GameObject;
        mur6_ = Instantiate(mur6);
        mur6_.name = "mur6";
        mur6_.transform.localPosition = new Vector3(width / 2 + 0.3f, 3, 0);
        mur6_.transform.localScale = mur2_.transform.localScale;

        mur7 = Resources.Load("Rooms/mur7") as GameObject;
        mur7_ = Instantiate(mur7);
        mur7_.name = "mur7";
        mur7_.transform.localPosition = new Vector3(0, 3, mur3_.transform.localPosition.z-0.2f);
        mur7_.transform.localScale = mur1_.transform.localScale;

        mur8 = Resources.Load("Rooms/mur8") as GameObject;
        mur8_ = Instantiate(mur8);
        mur8_.name = "mur8";
        mur8_.transform.localPosition = new Vector3(mur4_.transform.localPosition.x + .2f, 3, 0);
        mur8_.transform.localScale = mur2_.transform.localScale;

    }

    private void Update()
    {
        Debug.Log("isPressed : " + isPressed);
        if (isPressed)
        {
        inputLength.text = "";
        inputWidth.text = "";
        }

        if (inputLength.text != "" && inputWidth.text != "")
        {
            Button_create_room.interactable = true;
        }
        else {
            Button_create_room.interactable = false;

        }
    }
}
