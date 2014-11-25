using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	//Test
	public bool dead = false;
	const int health = 5;
	public int damage = 0;
	computer computerScript;
	// Use this for initialization
	void Start () {
		//Debug.Log("Health " + health.ToString());
		computerScript = GameObject.Find("computer").GetComponent<computer>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,-.01f,0));
		if(damage  >= health)
		{
			dead = true;
			computerScript.money+=25;
			Destroy(this.gameObject);
		}
	}


}
