using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauvegardeData : MonoBehaviour {

	public void SaveData()
    {
        Debug.Log("On sauvegarde les data"+ Application.persistentDataPath);
    }

    public void LoadData()
    {
        Debug.Log("On charge les data");
    }
}
