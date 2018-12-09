using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{

    //ATTENTION REGLER LE PROBLEME DU CLONE

    public Canvas canvas;

    public GameObject ImageColoPrefab;
    public Vector3 ImagePosition;
    public GameObject panelColorPalette;

    public GameObject[] tabImage;
    public Image[] tabStockageImage;
    public Material[] tabMat = new Material[90];
    public static Material[] tabStockageMat = new Material[90];

    float posiXDefault = 98.4f;
    float posiYDefault = 67.3f;

    static int cpt = 0;

    //buttons
    public GameObject buttonColorPrefab;
    public GameObject[] tabButton;
    public Button[] tabStockageButton;

    public void ColorManager_()
    {


        tabImage = new GameObject[90];
        tabStockageImage = new Image[tabImage.Length];

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
                    GameObject currentImage = Instantiate(ImageColoPrefab, canvas.transform) as GameObject;
                    Image img = currentImage.GetComponent<Image>();
                    img.name = "img-" + i;
                    img.color = tabMat[i].color;
                    RectTransform rectTransform = currentImage.GetComponent<RectTransform>();
                    rectTransform.transform.localPosition = new Vector3(posiXDefault + (m * 18), posiYDefault - (k * 18), 0);

                    tabStockageImage[i] = img;
                    i++;
                    m++;
                }
                k++;
            }
            panelColorPalette.SetActive(true);
            cpt++;
        }
    }


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
        }
        tabStockageMat = tabMat;
    }


   /* private void Update()
    {
        for (int i = 0; i < tabButton.Length; i++)
        {
        tabButton[i].GetComponent<Change_Color>().i= i;
        }
    }*/

}


