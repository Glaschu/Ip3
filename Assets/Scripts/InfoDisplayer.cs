using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InfoDisplayer : MonoBehaviour {
	public Text money;
	public GameObject keeper;
	// Use this for initialization
	void Start () {
		keeper = GameObject.Find("Keeper");
	}
	
	// Update is called once per frame
	void Update () {
		money.text = (" " + keeper.GetComponent<ButtonMonitor> ().city1Money);

	}
}
