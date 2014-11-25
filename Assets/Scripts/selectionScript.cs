using UnityEngine;
using System.Collections;

public class selectionScript : MonoBehaviour {


	//Ring around object
	public GameObject selectedIcon;
	//private reference to selectedIcon;
	GameObject selectedI;
	//Tower object
	public GameObject parentObj;
	public bool emptyT;

	// Use this for initialization
	void Start () {

		selectedI = (GameObject) Instantiate(selectedIcon,new Vector3(parentObj.transform.position.x,parentObj.transform.position.y,parentObj.transform.position.z-.01f)
		                                     ,transform.rotation);
		if(emptyT)
			selectedI.transform.Rotate(new Vector3(90,0,0));
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnDestroy()
	{
		DestroyObject(selectedI);
	}
}
