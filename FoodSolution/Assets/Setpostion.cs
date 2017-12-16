using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setpostion : MonoBehaviour {

    public  Vector3 A;
    public potatoClick potato;

	// Use this for initialization
	void Start () {
        transform.localPosition = A;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setpos(int posFirst, int x, int y)
    {
        //potato.SproutPostion[posFirst, 0] = x;  
        //potato.SproutPostion[posFirst, 1] = y;
        //potato.SproutPostion[posFirst, 2] = 0;
        //Debug.Log(potato.SproutPostion[posFirst, 0]);
    }
}
