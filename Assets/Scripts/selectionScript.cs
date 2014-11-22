using UnityEngine;
using System.Collections;

public class selectionScript : MonoBehaviour {


	//Ring around object
	public GameObject selectedIcon;
	//private reference to selectedIcon;
	GameObject selectedI;
	//Tower object
	public GameObject parentObj;

	// Use this for initialization
	void Start () {

		selectedI = (GameObject) Instantiate(selectedIcon,new Vector3(parentObj.transform.position.x,parentObj.transform.position.y,parentObj.transform.position.z+.3f),parentObj.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnDestroy()
	{
		DestroyObject(selectedI);
	}
}
