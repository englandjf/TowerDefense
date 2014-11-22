﻿using UnityEngine;
using System.Collections;

//add tower specific things in here
//shoots fast, little damage

public class tower1Script : MonoBehaviour {

	public int level = 1;
	public int damage = 2;
	public float shootTime = 1.0f;
	public GameObject parentTower;
	tower parentScript;

	// Use this for initialization
	void Start () {
		parentScript = parentTower.GetComponent<tower>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{	if(parentScript.selected)
		{
			GUI.Box(new Rect(10,10,100,90), "Tower 1");
		}

		if(parentScript.overTower)
		{
			GUI.color = Color.green;
			GUI.Label(new Rect(Input.mousePosition.x,Screen.height-Input.mousePosition.y-40,100,100),level.ToString());
			GUI.color = Color.red;
			GUI.Label(new Rect(Input.mousePosition.x,Screen.height-Input.mousePosition.y-20,100,100),damage.ToString());
		}
		
	}


}
