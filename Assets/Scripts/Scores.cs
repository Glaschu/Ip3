using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scores : MonoBehaviour {
	
	public float timer = 10f;
	public GameObject keep;


	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		keep = GameObject.Find("Keeper");
		
	}

	// Use this for initialization
	void Start () {
		
		//print("Starting " + Time.time);
		StartCoroutine(ScoreUpdate(timer));
		//print("Before WaitAndPrint Finishes " + Time.time);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("hello"+infoButton [0.0]);
	}
	IEnumerator ScoreUpdate(float waitTime) {
		yield return new WaitForSeconds(waitTime);

		keep.GetComponent<ButtonMonitor> ().calculate ();
		StartCoroutine(ScoreUpdate(timer));
	}


}
