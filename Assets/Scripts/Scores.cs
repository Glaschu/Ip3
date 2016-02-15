using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scores : MonoBehaviour {
	int city1Money =0;
	int research=0;
	public float timer = 10f;
	public Button[] buttons;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		//print("Starting " + Time.time);
		StartCoroutine(ScoreUpdate(timer));
		//print("Before WaitAndPrint Finishes " + Time.time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator ScoreUpdate(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		print("WaitAndPrint " + Time.time);
		StartCoroutine(ScoreUpdate(timer));
	}
}
