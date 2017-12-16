using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatoClick : MonoBehaviour {
    public GameObject Sprout;
    public GameObject sub;
    public GameObject[] SproutDel = new GameObject[8];
    public bool[] SproutCheck = new bool[8];
    public int[,]SproutPostion= new int[8,3];
    public int a = 100;
    int x ,y , Boxcnt ,  fullSprout;

	// Use this for initialization
	void Start () 
    {
        for(int i=0;i<7;i++)
        {
            SproutDel[i] = GameObject.Find("Sprout" + i);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}

     void OnClick()
     {
         
          Boxcnt = PlayerPrefs.GetInt("SproutPostionCnt", 0);
          fullSprout = PlayerPrefs.GetInt("fullSprout", 0);
          x = PlayerPrefs.GetInt("SproutPostionX"+fullSprout, 0);
          y = PlayerPrefs.GetInt("SproutPostionY"+fullSprout, 0);
          if ((PlayerPrefs.GetInt("SproutCheck" + fullSprout, 0)) == 0)
         {
             sub = (GameObject)Instantiate(Sprout);
             sub.GetComponent<Setpostion>().A = new Vector3(x, y, 0);
         }
       //  sub.name = "Sprout" + fullSprout;
         PlayerPrefs.SetInt("SproutCheck" + fullSprout, 1);
         SproutPostion[fullSprout, 0] = x;
         SproutPostion[fullSprout, 1] = y;
         SproutPostion[fullSprout, 2] = 0;

        // SproutDel[1] = GameObject.Find("SproutCheck1");
     }
}
