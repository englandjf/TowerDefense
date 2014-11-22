using UnityEngine;
using System.Collections;

//add tower specific things in here
//shoots slow,more damage

public class tower2Script : MonoBehaviour {

	public int level;
	public int damage;
	public int shootTime;
	public GameObject parentTower;
	tower parentScript;

	// Use this for initialization
	void Start () {
		level = 1;
		damage = 2;
		shootTime = 2;
		parentScript  = parentTower.GetComponent<tower>();
		Debug.Log ("T2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{	
		if(parentScript.selected)
		{
			GUI.Box(new Rect(10,10,100,90), "Tower 2");
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

