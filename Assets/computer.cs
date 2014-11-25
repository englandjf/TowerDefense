using UnityEngine;
using System.Collections;

//controls the flow of the game

public class computer : MonoBehaviour {

	public int money;
	public int baseHealth;
	public GameObject enemy1;

	int spawnTimer;

	// Use this for initialization
	void Start () {
		spawnTimer = 1;
		money = 200;
		baseHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > spawnTimer){
			Instantiate(enemy1,new Vector3(1.25f,6,-.15f),transform.rotation);
			spawnTimer += 2;
		}
	}

	void OnGUI()
	{
		GUI.color = Color.yellow;
		GUI.Label(new Rect(10,Screen.height-40,100,20),"Money: " + money);
		GUI.color = Color.green;
		GUI.Label(new Rect(10,Screen.height-20,100,20),"Health: " + baseHealth);
	}
}
