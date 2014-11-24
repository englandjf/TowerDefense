using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour {



	public bool inside = false;
	public Collider enemy = null;

	// Use this for initialization
	void Start () {
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
