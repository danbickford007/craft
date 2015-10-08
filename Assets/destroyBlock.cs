using UnityEngine;
using System.Collections;

public class destroyBlock : MonoBehaviour {

	GameObject clickedItem = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

//	private void OnMouseEnter() {
//		Debug.Log ("Mousing.....");
//		Debug.Log ("Mousing the block " + gameObject.name);
//		clickedItem = gameObject;
//	}



	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Removing block -> " + clickedItem.name);
			Destroy (this.gameObject);
		}

	}   
}
