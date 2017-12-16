using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delsprout : MonoBehaviour {
    public GameObject potato;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
       // sub.GetComponent<Setpostion>().A = new Vector3(x, y, 0);
        potato = new GameObject();
        potato = GameObject.Find("potato").GetComponent<potatoClick>().SproutDel[PlayerPrefs.GetInt("fullSprout")];
        Destroy(potato);
        PlayerPrefs.SetInt("SproutCheck" + PlayerPrefs.GetInt("fullSprout"), 0);
    }
}
