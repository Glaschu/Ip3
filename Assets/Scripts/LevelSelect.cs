using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(int level){
	
		Application.LoadLevel (1);
	}
}
