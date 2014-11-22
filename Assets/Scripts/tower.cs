using UnityEngine;
using System.Collections;

//ADD collision for enemies

public class tower : MonoBehaviour {

	//Created on collision
	public GameObject bullet;
	//Object for selection
	public GameObject selectedIcon;
	//Script for collisions 
	collisionScript childScript;
	//script for detecting selection
	selectionScript SS;
	//mouse is over tower
	public bool overTower;
	//tower is selected
	public bool selected = true;
	// Use this for initialization
	//pick what tower script to attach
	public int towerNum;
	//shoot timer
	public int shootTimer = 0;
	//helper variable
	float nextShot = 0.0f;
	//scripts for each tower
	tower1Script tower1;
	tower2Script tower2;


	void Start () {

		transform.eulerAngles = new Vector3(90,180,0);
		childScript = gameObject.GetComponentInChildren<collisionScript>();

		//Decided which tower script to create
		if(towerNum == 1)
		{
			tower1 = gameObject.AddComponent<tower1Script>();
			tower1.parentTower = this.gameObject;
			shootTimer = tower1.shootTime;
		}
		else if(towerNum == 2)
		{
			tower2 = gameObject.AddComponent<tower2Script>();
			tower2.parentTower = this.gameObject;
			shootTimer = tower2.shootTime;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//SAME SELECTION
		//Mouse clicked and not in sidebar
		shootTimer++;
		if(Input.GetMouseButton(0) && Input.mousePosition.x > 100)
		{
			if(overTower)
				selected = true;
			else
				selected = false;
		}
		//tower selected
		if(selected)
		{
			if(!SS){
				SS = gameObject.AddComponent<selectionScript>();
				SS.parentObj = this.gameObject;
				SS.selectedIcon = selectedIcon;
			}
		}
		else
		{
			if(SS)
			{
				Destroy(SS);
			}
			
		}
		//SAME SELECTION

		//Detects collision and shoots
		if(childScript.inside)
		{
			//Get object that is inside
			if(childScript.enemy){
				float eX = childScript.enemy.transform.position.x;
				float eY = childScript.enemy.transform.position.y;
				//slow down bullet firing
				if(Time.time > nextShot)
				{
					Debug.Log ("shot");
					GameObject enemy = (GameObject) Instantiate(bullet,transform.position,transform.rotation);
					bulletScript tempScript = enemy.GetComponent<bulletScript>();
					tempScript.posX = eX;
					tempScript.posY = eY;
					tempScript.posZ = transform.position.z;
					tempScript.enemy = childScript.enemy.gameObject;
					//set shoot time
					nextShot = Time.time + shootTimer;
				}
			}
		}
	}

	void OnMouseOver()
	{
		overTower = true;
	}
	
	void OnMouseExit()
	{
		overTower = false;
	}

	void OnGUI()
	{
		GUI.Label(new Rect(50,50,50,50),Time.time.ToString());
	}


}
