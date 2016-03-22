using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InfoDisplayer : MonoBehaviour {
	public Text money;
	public Text Pol;
	public Text Energy;
	public Text Res;
	public Text Year;
	public GameObject keeper;
	// Use this for initialization
	void Start () {
		keeper = GameObject.Find("Keeper");
	}
	
	// Update is called once per frame
	void Update () {
		//money.text = (" " + keeper.GetComponent<ButtonMonitor> ().city1Money);
		money.text = (" " + keeper.GetComponent<ButtonMonitor> ().globalMoney);
		Pol.text=  (" " + keeper.GetComponent<ButtonMonitor> ().TotalPol +"/500 P");
		Energy.text = (" " + keeper.GetComponent<ButtonMonitor> ().TotalEnergy +"/500 E");
		if (keeper.GetComponent<Scores> ().researchable) {
			Res.text = ("Not res");
		} else {
			Res.text = ("researching");
		}
		Year.text = (" " + keeper.GetComponent<Scores> ().year);
	}
}
