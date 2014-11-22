using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour {



	public bool inside;
	public Collider enemy;

	// Use this for initialization
	void Start () {
		inside = false;
		enemy = null;
	}
	
	// Update is called once per frame
	void Update () {
		if(!enemy)
			inside = false;
	}

	void OnTriggerEnter(Collider col)
	{
		enemy = col;
		inside = true;
	}

	void OnTriggerExit(Collider col)
	{
		enemy = col;
		inside = false;
	}

}
