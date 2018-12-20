using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public Canvas canvas;

    public GameObject ImageColoPrefab;
    public Vector3 ImagePosition;
    public GameObject panelColorPalette;
    public GameObject panelTextePalette;

    public GameObject[] tabImage;
    public Image[] tabStockageImage;
    public Material[] tabMat = new Material[90];
    public static Material[] tabStockageMat = new Material[90];

    float posiXDefault = 98.4f;
    float posiYDefault = 45.1f;

    static int cpt = 0;

    //buttons
    public GameObject buttonColorPrefab;
    public GameObject[] tabButton;
    public Button[] tabStockageButton;
    GameObject[] btnTabTag = new GameObject[90];

    public void ColorManager_Avec_Bouton()
    {
        tabButton = new GameObject[90];
        tabStockageButton = new Button[tabButton.Length];
        int i = 0;
        int k = 0;
        int m = 0;
        if (cpt == 0)
        {
            while (k < 10)
            {
                m = 0;
                while (m < 9)
                {
                    GameObject currentButton = Instantiate(buttonColorPrefab, canvas.transform) as GameObject;
                    Button btn = currentButton.GetComponent<Button>();
                    btn.name = "" + i;
                    btn.tag = "btn";
                    btn.GetComponent<Image>().color = tabMat[i].color;
                    RectTransform rectTransform = currentButton.GetComponent<RectTransform>();
                    rectTransform.transform.localPosition = new Vector3(posiXDefault + (m * 18), posiYDefault - (k * 18), 0);

                    tabStockageButton[i] = btn;
                    i++;
                    m++;
                }
                k++;
            }
            panelColorPalette.SetActive(true);
            cpt++;
            btnTabTag = GameObject.FindGameObjectsWithTag("btn");
        }
        else
        {
            Debug.Log("Hello World");
            ActiverPaletteCouleur(true);
        }
        tabStockageMat = tabMat;
    }



    static int cnt = 0;
    void ActiverPaletteCouleur(bool leBool)
    {
        cnt++;

        panelColorPalette.SetActive(leBool);

        for (int i = 0; i < btnTabTag.Length; i++)
        {
            btnTabTag[i].SetActive(leBool);
            // Debug.Log("bouton : " + btnTabTag[i]);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (panelColorPalette.active == true )
            {
                ActiverPaletteCouleur(false);
            }
        }

        if (ActionObject.active == false && panelColorPalette.active == true)
        {
            ActiverPaletteCouleur(false);
        }
    }

}


