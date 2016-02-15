using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scores : MonoBehaviour {
	
	public float timer = 10f;
	private static Scores keep;


	void Awake() {
		//if we don't have an [_instance] set yet
		if (!keep) {
			keep = this;
		}
		//otherwise, if we do, kill this thing
		else {
			Destroy (this.gameObject);
		}
		
		DontDestroyOnLoad(transform.gameObject);
		//keep = GameObject.Find("Keeper");
		
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
