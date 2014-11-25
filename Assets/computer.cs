using UnityEngine;
using System.Collections;

//controls the flow of the game

public class computer : MonoBehaviour {

	public int money;
	public int baseHealth;

	// Use this for initialization
	void Start () {
		money = 200;
		baseHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.color = Color.yellow;
		GUI.Label(new Rect(10,Screen.height-40,100,20),"Money: " + money);
		GUI.color = Color.green;
		GUI.Label(new Rect(10,Screen.height-20,100,20),"Health: " + baseHealth);
	}
}
