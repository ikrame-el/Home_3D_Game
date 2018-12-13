using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ActionObject : MonoBehaviour
{
    Transform canevas_transform;

    bool isPressed;

    GameObject b_delete;
    GameObject b_rotate;
    //GameObject b_color;
    GameObject b_texture;
    GameObject menu_ac;

    static GameObject b_delete_;
    static GameObject b_rotate_;
    //static GameObject b_color_;
    static GameObject b_texture_;
    static GameObject menu_ac_;

    public static bool active;


    private void Start()
    {
        canevas_transform = GameObject.FindGameObjectWithTag("canevas").transform;
    }

    public void createButton()
    {
        //menu cadre
        menu_ac = Resources.Load("Button_Actions/menu_ac") as GameObject;
        menu_ac_ = Instantiate(menu_ac, canevas_transform);

        //delete bouton
        b_delete = Resources.Load("Button_Actions/Button_delete") as GameObject;
        b_delete_ = Instantiate(b_delete, canevas_transform);

        //rotation bouton
        b_rotate = Resources.Load("Button_Actions/Button_rotate") as GameObject;
        b_rotate_ = Instantiate(b_rotate, canevas_transform);

        //color bouton
        //b_color = Resources.Load("Button_Actions/Button_color") as GameObject;
        //b_color_ = Instantiate(b_color, canevas_transform);

        //texture bouton
        b_texture = Resources.Load("Button_Actions/Button_texture") as GameObject;
        b_texture_ = Instantiate(b_texture, canevas_transform);

    }


    void OnMouseDown()
    {
        active = true;
        //Ici on deselectionne tous les autres objets qui ont le script ActionObject
        ActionObject[] objects = GameObject.FindObjectsOfType<ActionObject>();

        foreach (var item in objects)
        {
            if (item != this)
            {
                item.Deselect();
            }
        }

        if (b_delete_ == null && b_rotate_ == null && b_texture_ == null && menu_ac_ == null)
        {
            createButton();
        }

        Utils_.Active_Desactive_4(b_delete_, b_rotate_, b_texture_, menu_ac_, true);

        b_delete_.GetComponent<Delete_Button>().current_furniture = this;
        b_rotate_.GetComponent<Rotation_button>().current_f = this;

        isPressed = true;
    }

    public void Deselect()
    {

        isPressed = false;
    }

    public void DeleteObject()
    {
        Utils_.Active_Desactive_4(b_delete_, b_rotate_, b_texture_, menu_ac_, false);
        //Destroy(gameObject);
        Destroy(ObjectSelected.currentObject);
        active = false;
    }


    public void RotationObject()
    {
        transform.Rotate(Vector3.up * 45, Space.Self);
    }

    public GameObject camFPS;

    private void Update()
    {
        //liste de tous les gameobjects qui on le composant ActionObject
        //GameObject.FindObjectsOfType<ActionObject>();
        if (isPressed)
        {
            //deplacement d'un meuble dans la scene
            if (ObjectSelected.currentObject.tag != "room" && ObjectSelected.currentObject != null && Change_3D_2D.camFPSActive == false)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position += new Vector3(-.5f, 0, 0);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position += new Vector3(.5f, 0, 0);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    this.transform.position += new Vector3(0, 0, .5f);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    this.transform.position += new Vector3(0, 0, -.5f);
                }
            }

            if (Input.GetMouseButtonDown(1) && b_delete_ != null && b_rotate_ != null && b_texture_ != null && menu_ac_ != null)
            {
                Utils_.Active_Desactive_4(b_delete_, b_rotate_, b_texture_, menu_ac_, false);
                active = false;
            }
        }

    }
}
