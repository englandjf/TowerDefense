using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	//Test
	public bool dead = false;
	public int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,-.01f,0));
		if(health <= 0)
		{
			dead = true;

			Destroy(this.gameObject);
		}
	}


}
