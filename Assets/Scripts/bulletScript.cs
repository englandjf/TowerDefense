using UnityEngine;
using System.Collections;


//Add rotation to bullet
public class bulletScript : MonoBehaviour {

	public float posX;
	public float posY;
	public float posZ;
	public GameObject enemy;
	enemyScript enemyInfo;

	float speed = 5.0f;
	// Use this for initialization
	void Start () {

		transform.eulerAngles = new Vector3(0,0,180);
		enemyInfo = enemy.GetComponent<enemyScript>();



	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(.1f,0,0));
		//if(!enemyInfo)
		//	Debug.Log ("TesT");
		if(!enemy)
			Destroy(this.gameObject);
		transform.position = Vector3.MoveTowards(transform.position,new Vector3(posX,posY,posZ),speed*Time.deltaTime);//new Vector3(posX,posY,posZ)
	}

	void OnTriggerEnter(Collider col)
	{
		enemyInfo.health--;
		Destroy(this.gameObject);

	}
	

}
