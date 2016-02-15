using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public GameObject destroyObj;
	// Use this for initialization
	void Start () {
		//
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnLevelWasLoaded(int level) {
		destroyObj = GameObject.FindGameObjectWithTag("Destroy");
		Destroy (destroyObj);

	}
}