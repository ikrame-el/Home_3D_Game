using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPanel : MonoBehaviour
{
    public Button next_button;
    public Button preview_button;
    public Button start_button;
    public Button instructions_button;

    public GameObject panel_start;
    public GameObject[] panel_ = new GameObject[11];

    public string nomScene;
    int cpt = 0;

    int previewPanel;
    int currentPanel;
    int nextPanel;

    private void Start()
    {

        //desactiver tous les panels au demarrage et les boutons next et preview
        Activer_Desactiver_panels(start_button, instructions_button, next_button, preview_button, false);
    }

    void Activer_Desactiver_panels(Button buttonActive1, Button buttonActive2, Button buttonDesactive1, Button buttonDesactive2, bool boolPanel)
    {
        for (int i = 0; i < panel_.Length; i++)
        {
            panel_[i].SetActive(boolPanel);
        }
        Utils_.Active_Desactive_2(buttonActive1.gameObject, buttonActive2.gameObject, true);
        Utils_.Active_Desactive_2(buttonDesactive1.gameObject, buttonDesactive2.gameObject, false);
    }

    public void Next_panel()
    {
        panel_[cpt - 1].SetActive(false);
        panel_[cpt].SetActive(true);
        cpt++;
    }

    public void Preview_panel()
    {
        if (cpt == 0)
        {
            panel_start.SetActive(true);
            Activer_Desactiver_panels(start_button, instructions_button, next_button, preview_button, false);
        }
        else
        {
            panel_[cpt].SetActive(false);
            panel_[cpt - 1].SetActive(true);
            cpt--;
        }

    }

    public void Instructions()
    {
        cpt = 0;
        panel_start.SetActive(false);
        Utils_.Active_Desactive_3(panel_[cpt], next_button.gameObject, preview_button.gameObject, true);

        currentPanel = cpt;
        cpt++;
        Debug.Log("RUUULES");
    }

    public void Play()
    {
        Application.LoadLevel(nomScene);
    }

    IEnumerator Attendre2sec()
    {
        next_button.interactable = false;
        Debug.Log("COOOORROOUUUUtinee AVANT");
        yield return new WaitForSeconds(3.0f);
        Debug.Log("COOOORROOUUUUtinee Apres");
        cpt = 0;
        panel_start.SetActive(true);
        Activer_Desactiver_panels(start_button, instructions_button, next_button, preview_button, false);
        next_button.interactable = true;
    }

    private void Update()
    {
        if (cpt == 0)
        {
            Utils_.Active_Desactive_2(start_button.gameObject, instructions_button.gameObject, true);
        }
        else
        {
            Utils_.Active_Desactive_2(start_button.gameObject, instructions_button.gameObject, false);
        }
        Debug.Log("CPT = " + cpt);
        if (cpt == 11)
        {
            StartCoroutine("Attendre2sec");
        }
    }
}
