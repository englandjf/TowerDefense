using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	//Test
	public bool dead = false;
	const int health = 5;
	public int damage = 0;
	// Use this for initialization
	void Start () {
		Debug.Log("Health " + health.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,-.01f,0));
		if(damage  >= health)
		{
			dead = true;

			Destroy(this.gameObject);
		}
	}


}
