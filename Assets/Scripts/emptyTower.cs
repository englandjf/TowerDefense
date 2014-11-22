using UnityEngine;
using System.Collections;

public class emptyTower : MonoBehaviour {


	//public GameObject bullet;
	public GameObject selectedIcon;
	//towers
	public GameObject tower1;
	public GameObject tower2;
	//collisionScript childScript;
	//script for detecting selection
	selectionScript SS;
	//mouse is over tower
	bool overTower;
	//tower is selected
	bool selected;
	
	// Use this for initialization
	void Start () {
//		childScript = gameObject.GetComponentInChildren<collisionScript>();
	}
	
	// Update is called once per frame
	void Update () {
		//SAME SELECTION
		//Mouse clicked and not in sidebar
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

		/*
		if(childScript.inside)
		{
			//Get object that is inside
			float eX = childScript.enemy.transform.position.x;
			float eY = childScript.enemy.transform.position.y;
			GameObject enemy = (GameObject) Instantiate(bullet,transform.position,transform.rotation);
			bulletScript tempScript = enemy.GetComponent<bulletScript>();
			tempScript.posX = eX;
			tempScript.posY = eY;
			tempScript.posZ = transform.position.z;
			tempScript.enemy = childScript.enemy.gameObject;
		}
		*/

	}



	void OnMouseOver()
	{
		overTower = true;
	}

	void OnMouseExit()
	{
		overTower = false;
	}

	//BaseTower dependent
	void OnGUI()
	{
		if(selected)
		{
			GUI.Box(new Rect(10,10,100,90), "Loader Menu");

			if(GUI.Button(new Rect(20,40,80,20), "Tower 1")) {

				GameObject temp =  (GameObject) Instantiate(tower1,transform.position,transform.rotation);
				tower temp2 = temp.GetComponent<tower>();
				temp2.towerNum = 1;
				Destroy(this.gameObject);
			}
			
			// Make the second button.
			if(GUI.Button(new Rect(20,70,80,20), "Tower 2")) {			
				GameObject temp = (GameObject) Instantiate(tower2,transform.position,transform.rotation);
				tower temp2 = temp.GetComponent<tower>();
				temp2.towerNum = 2;
				Destroy(this.gameObject);

			}
		}
	}
}
