using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;

public class Menus : MonoBehaviour {
	private Sprite[] textures;
	public GameObject UpgradeMenu;
	public GameObject keep;
	public GameObject MoneyPop;
	public GameObject ResearchPop;
	public int buttonClicked =0;
	public int updateClicked=0;
	public Button clickedName1,clickedName2,clickedName3;
	//coal1,coal2,coal3,Geo1,Geo2,Geo3,nuclear1,nuclear2,nuclear3,Oil1 ,Oil2 ,Oil3,tidal1,tidal2,tidal3,Hydro1,Hydro2,Hydro3,Gas1,Gas2,Gas3,Wind1,Wind2,Wind3,Solar1,Solar2,Solar3,Farm11,Farm12,Farm13,Farm21,Farm22,Farm23,Farm31,Farm32,Farm33
	public int[] CosttoBuild =new int[]{5000,2500,3000,10000,13000,14000,25000,75000,100000,3000,4000,5000,5000,2500,4500,10000,15000,20000,1500,3000,6000,5000,2500,2500,7000,4000,3500,10000,12500,15000,17000,20000,25000,30000,32500,35000};

	// Use this for initialization
	void Start () {
		

	}
	void Awake(){
		textures=Resources.LoadAll<Sprite>("UpGradeButtons");
		keep = GameObject.Find("Keeper");
		if (keep == null) {
			Debug.LogError("keep Loading Error");

		}
		MoneyPop.SetActive(false);
		ResearchPop.SetActive(false);
		}
	
	
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClick(int select){
		MoneyPop.SetActive(false);
		ResearchPop.SetActive(false);
		UpgradeMenu.SetActive(true);
		buttonClicked = select;
		updateClicked = 0;
		clickedName1.interactable = false;
		clickedName2.interactable = false;
		clickedName3.interactable = false;
	}
	public void OnUpgradeButtonClick(int select){
		updateClicked = select;
		UpgradeMenu.SetActive(false);
		clickedName1.interactable = true;
		clickedName2.interactable = true;
		clickedName3.interactable = true;
		//check money
		if (Unlocked (select)) {
			if (keep.GetComponent<ButtonMonitor> ().globalMoney >= CosttoBuild [updateClicked]) {
				keep.GetComponent<ButtonMonitor> ().setbuttons (buttonClicked, updateClicked);
				//keep.GetComponent<ButtonMonitor> ().UpgradeArray (buttonClicked, updateClicked);
				ChangeTex (buttonClicked, updateClicked);
			} else {
				//not enoff money
				MoneyPop.SetActive(true);
				ResearchPop.SetActive(false);
				Debug.Log ("no monney");
			}
		} else {
		//not resurched
			MoneyPop.SetActive(false);
			ResearchPop.SetActive(true);
			//Debug.Log ("Not resarched");
		}
	}
	public void ChangeTex(int SlotClicked,int Upgrade){
		
		if (SlotClicked == 0) {
			switch (Upgrade)
			{
			case 0:
				clickedName1.image.sprite = textures[0];
				break;
			case 1:
				clickedName1.image.sprite = textures[1];
				break;
			case 2:
				clickedName1.image.sprite = textures[2];
				break;
			case 3:
				clickedName1.image.sprite = textures[3];
				break;
			case 4:
				clickedName1.image.sprite = textures[4];
				break;
			case 5:
				clickedName1.image.sprite = textures[5];
				break;
			case 6:
				clickedName1.image.sprite = textures[6];
				break;
			case 7:
				clickedName1.image.sprite = textures[7];
				break;
			case 8:
				clickedName1.image.sprite = textures[8];
				break;
			case 9:
				clickedName1.image.sprite = textures[9];
				break;
			case 10:
				clickedName1.image.sprite = textures[10];
				break;
			case 11:
				clickedName1.image.sprite = textures[11];
				break;
			case 12:
				clickedName1.image.sprite = textures[12];
				break;
			case 13:
				clickedName1.image.sprite = textures[13];
				break;
			case 14:
				clickedName1.image.sprite = textures[14];
				break;
			case 15:
				clickedName1.image.sprite = textures[15];
				break;
			case 16:
				clickedName1.image.sprite = textures[16];
				break;
			case 17:
				clickedName1.image.sprite = textures[17];
				break;
			case 18:
				clickedName1.image.sprite = textures[18];
				break;
			case 19:
				clickedName1.image.sprite = textures[19];
				break;
			case 20:
				clickedName1.image.sprite = textures[20];
				break;
			case 21:
				clickedName1.image.sprite = textures[21];
				break;
			case 22:
				clickedName1.image.sprite = textures[22];
				break;
			case 23:
				clickedName1.image.sprite = textures[23];
				break;
			case 24:
				clickedName1.image.sprite = textures[24];
				break;
			case 25:
				clickedName1.image.sprite = textures[25];
				break;
			case 26:
				clickedName1.image.sprite = textures[26];
				break;
			case 27:
				clickedName1.image.sprite = textures[27];
				break;
			case 28:
				clickedName1.image.sprite = textures[28];
				break;
			case 29:
				clickedName1.image.sprite = textures[29];
				break;
			case 30:
				clickedName1.image.sprite = textures[30];
				break;
			case 31:
				clickedName1.image.sprite = textures[31];
				break;
			case 32:
				clickedName1.image.sprite = textures[32];
				break;
			case 33:
				clickedName1.image.sprite = textures[33];
				break;
			case 34:
				clickedName1.image.sprite = textures[34];
				break;
			case 35:
				clickedName1.image.sprite = textures[35];
				break;
			default:
				clickedName1.image.sprite = textures[36];
				break;
			}

		}else if (SlotClicked == 1) {
			switch (Upgrade)
			{
			case 0:
				clickedName2.image.sprite = textures[0];
				break;
			case 1:
				clickedName2.image.sprite = textures[1];
				break;
			case 2:
				clickedName2.image.sprite = textures[2];
				break;
			case 3:
				clickedName2.image.sprite = textures[3];
				break;
			case 4:
				clickedName2.image.sprite = textures[4];
				break;
			case 5:
				clickedName2.image.sprite = textures[5];
				break;
			case 6:
				clickedName2.image.sprite = textures[6];
				break;
			case 7:
				clickedName2.image.sprite = textures[7];
				break;
			case 8:
				clickedName2.image.sprite = textures[8];
				break;
			case 9:
				clickedName2.image.sprite = textures[9];
				break;
			case 10:
				clickedName2.image.sprite = textures[10];
				break;
			case 11:
				clickedName2.image.sprite = textures[11];
				break;
			case 12:
				clickedName2.image.sprite = textures[12];
				break;
			case 13:
				clickedName2.image.sprite = textures[13];
				break;
			case 14:
				clickedName2.image.sprite = textures[14];
				break;
			case 15:
				clickedName2.image.sprite = textures[15];
				break;
			case 16:
				clickedName2.image.sprite = textures[16];
				break;
			case 17:
				clickedName2.image.sprite = textures[17];
				break;
			case 18:
				clickedName2.image.sprite = textures[18];
				break;
			case 19:
				clickedName2.image.sprite = textures[19];
				break;
			case 20:
				clickedName2.image.sprite = textures[20];
				break;
			case 21:
				clickedName2.image.sprite = textures[21];
				break;
			case 22:
				clickedName2.image.sprite = textures[22];
				break;
			case 23:
				clickedName2.image.sprite = textures[23];
				break;
			case 24:
				clickedName2.image.sprite = textures[24];
				break;
			case 25:
				clickedName2.image.sprite = textures[25];
				break;
			case 26:
				clickedName2.image.sprite = textures[26];
				break;
			case 27:
				clickedName2.image.sprite = textures[27];
				break;
			case 28:
				clickedName2.image.sprite = textures[28];
				break;
			case 29:
				clickedName2.image.sprite = textures[29];
				break;
			case 30:
				clickedName2.image.sprite = textures[30];
				break;
			case 31:
				clickedName2.image.sprite = textures[31];
				break;
			case 32:
				clickedName2.image.sprite = textures[32];
				break;
			case 33:
				clickedName2.image.sprite = textures[33];
				break;
			case 34:
				clickedName2.image.sprite = textures[34];
				break;
			case 35:
				clickedName2.image.sprite = textures[35];
				break;
			default:
				clickedName2.image.sprite = textures[36];
				break;
			}

		}else if (SlotClicked == 2) {
			switch (Upgrade)
			{
			case 0:
				clickedName3.image.sprite = textures[0];
				break;
			case 1:
				clickedName3.image.sprite = textures[1];
				break;
			case 2:
				clickedName3.image.sprite = textures[2];
				break;
			case 3:
				clickedName3.image.sprite = textures[3];
				break;
			case 4:
				clickedName3.image.sprite = textures[4];
				break;
			case 5:
				clickedName3.image.sprite = textures[5];
				break;
			case 6:
				clickedName3.image.sprite = textures[6];
				break;
			case 7:
				clickedName3.image.sprite = textures[7];
				break;
			case 8:
				clickedName3.image.sprite = textures[8];
				break;
			case 9:
				clickedName3.image.sprite = textures[9];
				break;
			case 10:
				clickedName3.image.sprite = textures[10];
				break;
			case 11:
				clickedName3.image.sprite = textures[11];
				break;
			case 12:
				clickedName3.image.sprite = textures[12];
				break;
			case 13:
				clickedName3.image.sprite = textures[13];
				break;
			case 14:
				clickedName3.image.sprite = textures[14];
				break;
			case 15:
				clickedName3.image.sprite = textures[15];
				break;
			case 16:
				clickedName3.image.sprite = textures[16];
				break;
			case 17:
				clickedName3.image.sprite = textures[17];
				break;
			case 18:
				clickedName3.image.sprite = textures[18];
				break;
			case 19:
				clickedName3.image.sprite = textures[19];
				break;
			case 20:
				clickedName3.image.sprite = textures[20];
				break;
			case 21:
				clickedName3.image.sprite = textures[21];
				break;
			case 22:
				clickedName3.image.sprite = textures[22];
				break;
			case 23:
				clickedName3.image.sprite = textures[23];
				break;
			case 24:
				clickedName3.image.sprite = textures[24];
				break;
			case 25:
				clickedName3.image.sprite = textures[25];
				break;
			case 26:
				clickedName3.image.sprite = textures[26];
				break;
			case 27:
				clickedName3.image.sprite = textures[27];
				break;
			case 28:
				clickedName3.image.sprite = textures[28];
				break;
			case 29:
				clickedName3.image.sprite = textures[29];
				break;
			case 30:
				clickedName3.image.sprite = textures[30];
				break;
			case 31:
				clickedName3.image.sprite = textures[31];
				break;
			case 32:
				clickedName3.image.sprite = textures[32];
				break;
			case 33:
				clickedName3.image.sprite = textures[33];
				break;
			case 34:
				clickedName3.image.sprite = textures[34];
				break;
			case 35:
				clickedName3.image.sprite = textures[35];
				break;
			default:
				clickedName3.image.sprite = textures[36];
				break;
			}

		}

	}
	private bool Unlocked(int selected){
	
		switch (selected)
		{
		case 0:
			if (keep.GetComponent<TechTreeKeeper> ().CoalBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}

		case 1:
			if (keep.GetComponent<TechTreeKeeper> ().CoalBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}

		case 2:
			if (keep.GetComponent<TechTreeKeeper> ().CoalBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 3:
			if (keep.GetComponent<TechTreeKeeper> ().GeoBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}

		case 4:
			if (keep.GetComponent<TechTreeKeeper> ().GeoBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}

		case 5:
			if (keep.GetComponent<TechTreeKeeper> ().GeoBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 6:
			if (keep.GetComponent<TechTreeKeeper> ().NuclearBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}

		case 7:
			if (keep.GetComponent<TechTreeKeeper> ().NuclearBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}

		case 8:
			if (keep.GetComponent<TechTreeKeeper> ().NuclearBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 9:
			if (keep.GetComponent<TechTreeKeeper> ().OilBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}

		case 10:
			if (keep.GetComponent<TechTreeKeeper> ().OilBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 11:
			if (keep.GetComponent<TechTreeKeeper> ().OilBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 12:
			if (keep.GetComponent<TechTreeKeeper> ().TidalBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 13:
			if (keep.GetComponent<TechTreeKeeper> ().TidalBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 14:
			if (keep.GetComponent<TechTreeKeeper> ().TidalBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 15:
			if (keep.GetComponent<TechTreeKeeper> ().HydroBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 16:
			if (keep.GetComponent<TechTreeKeeper> ().HydroBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 17:
			if (keep.GetComponent<TechTreeKeeper> ().HydroBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 18:
			if (keep.GetComponent<TechTreeKeeper> ().GasBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 19:
			if (keep.GetComponent<TechTreeKeeper> ().GasBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}

		case 20:
			if (keep.GetComponent<TechTreeKeeper> ().GasBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 21:
			if (keep.GetComponent<TechTreeKeeper> ().WindBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 22:
			if (keep.GetComponent<TechTreeKeeper> ().WindBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 23:
			if (keep.GetComponent<TechTreeKeeper> ().WindBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 24:
			if (keep.GetComponent<TechTreeKeeper> ().SolarBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 25:
			if (keep.GetComponent<TechTreeKeeper> ().SolarBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 26:
			if (keep.GetComponent<TechTreeKeeper> ().SolarBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}

		case 27:
			if (keep.GetComponent<TechTreeKeeper> ().FarmBuilding (1) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 28:
			if (keep.GetComponent<TechTreeKeeper> ().FarmBuilding (2) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 29:
			if (keep.GetComponent<TechTreeKeeper> ().FarmBuilding (3) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 30:
			if (keep.GetComponent<TechTreeKeeper> ().Farm2Building (1) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 31:
			if (keep.GetComponent<TechTreeKeeper> ().Farm2Building (2) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 32:
			if (keep.GetComponent<TechTreeKeeper> ().Farm2Building (3) == 1) {
				return true;
			} else {
				return false;
			}
		
		case 33:
			if (keep.GetComponent<TechTreeKeeper> ().Farm3Building (1) == 1) {
				return true;
			} else {
				return false;
			}
	
		case 34:
			if (keep.GetComponent<TechTreeKeeper> ().Farm3Building (2) == 1) {
				return true;
			} else {
				return false;
			}

		case 35:
			if (keep.GetComponent<TechTreeKeeper> ().Farm3Building (3) == 1) {
				return true;
			} else {
				return false;
			}

		default:
			return false;
		
		}
	}
	public void closePops(){
		MoneyPop.SetActive(false);
		ResearchPop.SetActive(false);

	}
}
	