using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
	
	public float timer = 10f;
	public  int Upgradetime;
	public int hex;
	public int hexIn;
	private static Scores keep;
	public bool researchable;
	public int year=1950;

	void Awake ()
	{
		//if we don't have an [_instance] set yet
		if (!keep) {
			keep = this;
		}
		//otherwise, if we do, kill this thing
		else {
			Destroy (this.gameObject);
		}
		
		DontDestroyOnLoad (transform.gameObject);
		//keep = GameObject.Find("Keeper");
		
	}

	// Use this for initialization
	void Start ()
	{
		

		StartCoroutine (ScoreUpdate (timer));

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	IEnumerator ScoreUpdate (float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		year += 1;
		keep.GetComponent<ButtonMonitor> ().calulateGlobal ();
		if (Upgradetime > 1) {
			Upgradetime -= 1;
			researchable = false;
		} else {
			//set researchable true

			changeResearched ();
			researchable = true;
		}
		//keep.GetComponent<ButtonMonitor> ().calculate ();
		StartCoroutine (ScoreUpdate (timer));
	}

	void changeResearched ()
	{
		switch (hex) {
		case 0:
			//gameObject.GetComponent<TechTreeKeeper> ().CoalInfo [hexIn] = 1;
			break;
		case 1:
			gameObject.GetComponent<TechTreeKeeper> ().setCoal (hexIn);
			//Debug.Log ("testSave");
			//gameObject.GetComponent<TechTreeKeeper> ().CoalInfo [hexIn] = 1;
			break;
		case 2:
			gameObject.GetComponent<TechTreeKeeper> ().setGeo (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().GeoInfo [hexIn] = 1;
			break;
		case 3:
			gameObject.GetComponent<TechTreeKeeper> ().setNuclear (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().NuclearInfo [hexIn] = 1;
			break;
		case 4:
			gameObject.GetComponent<TechTreeKeeper> ().setOil (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().OilInfo [hexIn] = 1;
			break;
		case 5:
			gameObject.GetComponent<TechTreeKeeper> ().setTidal (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().TidalInfo [hexIn] = 1;
			break;
		case 6:
			gameObject.GetComponent<TechTreeKeeper> ().setHydro (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().HydroInfo [hexIn] = 1;
			break;
		case 7:
			gameObject.GetComponent<TechTreeKeeper> ().setGas (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().GasInfo [hexIn] = 1;
			break;
		case 8:
			gameObject.GetComponent<TechTreeKeeper> ().setWind (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().WindInfo [hexIn] = 1;
			break;
		case 9:
			gameObject.GetComponent<TechTreeKeeper> ().setSolar (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().SolarInfo [hexIn] = 1;
			break;
		case 10:
			gameObject.GetComponent<TechTreeKeeper> ().setFarms (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().FarmsInfo [hexIn] = 1;
			break;
		case 11:
			gameObject.GetComponent<TechTreeKeeper> ().setFarms2 (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().Farms2Info [hexIn] = 1;
			break;
		case 12:
			gameObject.GetComponent<TechTreeKeeper> ().setFarms3 (hexIn);
			//gameObject.GetComponent<TechTreeKeeper> ().Farms3Info [hexIn] = 1;
			break;
		default:
			break;
		}

	}

}



