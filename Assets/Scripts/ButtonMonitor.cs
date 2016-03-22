using UnityEngine;
using System.Collections;

public class ButtonMonitor : MonoBehaviour {
	
	public int[,] ButtonInfo = new int[,] { {  0, 0 }, //col 0   //stage 0    //{level,ButtonSlot,Upgrade}
									 {  1, 0 }, //col 1
									 {  2, 0 }, //col 2   //stageEnd 2  
									 {  0, 3 }, //col 3   //stage 3
									 {  1, 4 }, //col 4
								 	 {  2, 5 }, //col 5   //stageEnd 5  
									 {  0, 6 }, //col 6   //stage 6 
									 {  1, 7 }, //col 7
									 {  2, 8 }, //col 8   //stageEnd 8  
									 {  0, 9 }, //col 9   //stage 8 
									 {  1, 10 }, //col 10
		 							 {  2, 11 }, //col 11  //stageEnd 10  
									 {  0, 12 }, //col 12  //stage 12 
									 {  1, 13 }, //col 13
									 {  2, 14 }};//col 14  //stageEnd 14 
	int stage,stageEnd;
	public int city1Money,city2Money,city3Money,city4Money,city5Money,globalMoney;
	public int research;
	private int[] ButtonSlotInfo  = new int[] {0,9,18,36,36,36,36,36,36,36,36,36,36,36,36};
	public int[,] UpgradeInfo = new int[,] { {  0, 1,10 }, //col 0   //stage 0    //{upgrade,money,research}
											{  1, 1,10 }, //col 1
											{  2, 1,10 }, //col 2   //stageEnd 2  
											{  3, 50,10 }, //col 3   //stage 3
											{  4, 50,10 }, //col 4
											{  5, 50,10 }, //col 5   //stageEnd 5  
											{  6, 40,10 }, //col 6   //stage 6 
											{  7, 40,10 }, //col 7
											{  8, 40,10 }, //col 8   //stageEnd 8  
											{  9, 30,10 }, //col 9   //stage 8 
											{  10, 30,10 }, //col 10
											{  11, 10,10 }, //col 11  //stageEnd 10  
											{  12, 20,10 }, //col 12  //stage 12 
											{  13, 20,10 }, //col 13
											{  14, 10,10 }};//col 14  //stageEnd 14 
	
	public int[] UpgradeMoney = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

	GameObject keep,level;

	public int[,] GeoBuildings =new int[,]{{5000,10,50},{6000,5,60},{7000,0,70}};//money/pollution/energy
	public int[,] CoalBuildings =new int[,]{{5000,60,60},{10000,75,65},{20000,90,70}};
	public int[,] NuclearBuildings =new int[,]{{7500,20,0},{10000,10,300},{17000,0,500}};
	public int[,] OilBuildings =new int[,]{{20000,60,60},{40000,65,70},{60000,70,0}};
	public int[,] HydroBuildings =new int[,]{{5000,10,25},{10000,5,35},{12500,0,40}};    
	public int[,] TidalBuildings =new int[,]{{5000,10,25},{7500,5,35},{9000,5,40}};
	public int[,] GasBuildings =new int[,]{{10000,50,70},{150000,60,75},{30000,75,80}};    
	public int[,] WindBuildings =new int[,]{{1000,10,25},{2000,35,0},{3000,0,50}};
	public int[,] SolarBuildings =new int[,]{{2000,10,30},{3000,5,60},{4000,0,80}};
	public int[,] FarmsBuildings =new int[,]{{30000,-10,0},{40000,-15,0},{50000,-20,0}};
	public int[,] Farms2Buildings =new int[,]{{70000,-25,0},{90000,-40,0},{110000,-60,0}};
	public int[,] Farms3Buildings =new int[,]{{160000,-90,0},{200000,-120,0},{230000,-200,0}};
	public int CoalMoney, GeoMoney,nuclearMoney,oilMoney,hydroMoney,tidalMoney,gasMoney,windMoney,solarMoney,farm1Money,farm2Money,farm3Money;
	public int CoalPollution, GeoPollution,nuclearPollution,oilPollution,hydroPollution,tidalPollution,gasPollution,windPollution,solarPollution,farm1Pollution,farm2Pollution,farm3Pollution;
	public int CoalEnergy, GeoEnergy,nuclearEnergy,oilEnergy,hydroEnergy,tidalEnergy,gasEnergy,windEnergy,solarEnergy,farm1Energy,farm2Energy,farm3Energy;
	public int TotalPol, TotalEnergy, TotalMoney;
	//int slotClicked,SlotUpdate;
	// Use this for initialization
	void Start () {
		keep = GameObject.Find("Keeper");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.LogError ("still here");
		if( Input.GetKeyDown( KeyCode.Space ) )
			Debug.Log( ButtonSlotInfo[0]+""+ButtonSlotInfo[1]+""+ButtonSlotInfo[2]);
		if (Input.GetKeyDown(KeyCode.Q))
			Application.Quit();
	}


	void OnLevelWasLoaded(int level) {
		

		if (level == 1){
			stage = 0;
			stageEnd = 2;

			LoadButtons ();

		}
		else if(level == 3){
			stage = 3;
			stageEnd = 5;
			LoadButtons ();
		}else if(level == 4){
			stage = 6;
			stageEnd=8;
			LoadButtons ();
		}
		

	}
	void LoadButtons(){


		level = GameObject.Find ("Management");
		int buttonslots = 0;
		for (int i = stage; i <= stageEnd; i++) {
			{
				if (buttonslots == 0) {
					level.GetComponent<Menus> ().ChangeTex (buttonslots,ButtonSlotInfo[stage]);
					buttonslots = 1;
				} else if (buttonslots == 1) {
					level.GetComponent<Menus> ().ChangeTex (buttonslots,ButtonSlotInfo[stage+1]);
					buttonslots = 2;
				} else if (buttonslots == 2) {
					level.GetComponent<Menus> ().ChangeTex (buttonslots,ButtonSlotInfo[stage+2]);
					buttonslots = 3;
				}
				//int buttonslot = ButtonInfo[i,0];
				//int upgrade = ButtonInfo[i,1];
				//level.GetComponent<Menus> ().ChangeTex (2,3);
				//level.GetComponent<Menus> ().ChangeTex (buttonslot,upgrade);

					 //
				//ButtonSlotInfo

				}
			}   


		}
	void SaveButtons(int slotClick,int SlotUpdated ){
		
	//ButtonInfo [stage + slotClicked, 1] = SlotUpdate;
		ButtonInfo [stage + slotClick, 1] = SlotUpdated;
	}

	public void UpgradeArray(int slotClicked,int SlotUpdate){
		SaveButtons (slotClicked,SlotUpdate);
	}

	void TestButtons(){
		//int buttonslot, upgrade;
		for (int i = stage; i <= stageEnd; i++) {
			{
				for (int j = 0; j <= 1; j++) {
					if (j == 0) {
						//do nothing yet

						Debug.Log("slot "+ButtonInfo[i,j]);
					} else if (j == 1) {

						Debug.Log("upgrade "+ButtonInfo[i,j]);
						//upgrade = ButtonInfo [i, j];
					} 




				}
			}   
		}

	}

	public void calculate(){
		for (int i = 0; i <= 14; i++) {
			{
				research+= UpgradeInfo [ButtonInfo [i, 1], 2];
				if (i <= 2) {
					city1Money += UpgradeInfo [ButtonInfo [i, 1], 1];
				} else if (i <= 5) {
					city2Money += UpgradeInfo [ButtonInfo [i, 1], 1];
				}
				else if (i <= 8) {
					city3Money += UpgradeInfo [ButtonInfo [i, 1], 1];
				}else if (i <= 11) {
					city4Money += UpgradeInfo [ButtonInfo [i, 1], 1];
				}
				else if (i <= 14) {
					city5Money += UpgradeInfo [ButtonInfo [i, 1], 1];
				}


				
			}   
		}
	
	}
	public void calulateGlobal(){
		cleanEP ();
		for (int i = 0; i <= 14; i++) {
			if (ButtonSlotInfo [i] >= 0 && ButtonSlotInfo [i] <= 2) {
				//coal

				CoalMoney += CoalBuildings [ButtonSlotInfo [i], 0];
				CoalPollution += CoalBuildings [ButtonSlotInfo [i], 1];
				CoalEnergy += CoalBuildings [ButtonSlotInfo [i], 2];

			} else if (ButtonSlotInfo [i] >= 3 && ButtonSlotInfo [i] <= 5) {
				//geo

				GeoMoney += GeoBuildings [(ButtonSlotInfo [i]-3), 0];
				GeoPollution += CoalBuildings [(ButtonSlotInfo [i]-3), 1];
				GeoEnergy += CoalBuildings [(ButtonSlotInfo [i]-3), 2];

			} else if (ButtonSlotInfo [i] >= 6 && ButtonSlotInfo [i] <= 8) {
				//nuclear
				nuclearMoney += NuclearBuildings [(ButtonSlotInfo [i]-6), 0];
				nuclearPollution += CoalBuildings [(ButtonSlotInfo [i]-6), 1];
				nuclearEnergy += CoalBuildings [(ButtonSlotInfo [i]-6), 2];

			} else if (ButtonSlotInfo [i] >= 9 && ButtonSlotInfo [i] <= 11) {
				//oil

				oilMoney += OilBuildings [(ButtonSlotInfo [i]-9), 0];
				oilPollution += CoalBuildings [(ButtonSlotInfo [i]-9), 1];
				oilEnergy += CoalBuildings [(ButtonSlotInfo [i]-9), 2];

			} else if (ButtonSlotInfo [i] >= 12 && ButtonSlotInfo [i] <= 14) {
				//tidal
				tidalMoney += TidalBuildings [(ButtonSlotInfo [i]-12), 0];
				tidalPollution += CoalBuildings [(ButtonSlotInfo [i]-12), 1];
				tidalEnergy += CoalBuildings [(ButtonSlotInfo [i]-12), 2];

			} else if (ButtonSlotInfo [i] >= 15 && ButtonSlotInfo [i] <= 17) {
				//hydro
				hydroMoney += HydroBuildings [(ButtonSlotInfo [i]-15), 0];
				hydroPollution += CoalBuildings [(ButtonSlotInfo [i]-15), 1];
				hydroEnergy += CoalBuildings [(ButtonSlotInfo [i]-15), 2];

			} else if (ButtonSlotInfo [i] >= 18 && ButtonSlotInfo [i] <= 20) {
				//gas
				gasMoney += GasBuildings [(ButtonSlotInfo [i]-18), 0];
				gasPollution += CoalBuildings [(ButtonSlotInfo [i]-18), 1];
				gasEnergy += CoalBuildings [(ButtonSlotInfo [i]-18), 2];

			} else if (ButtonSlotInfo [i] >= 21 && ButtonSlotInfo [i] <= 23) {
				//wind
				windMoney += WindBuildings [(ButtonSlotInfo [i]-21), 0];
				windPollution += CoalBuildings [(ButtonSlotInfo [i]-21), 1];
				windEnergy += CoalBuildings [(ButtonSlotInfo [i]-21), 2];

			} else if (ButtonSlotInfo [i] >= 24 && ButtonSlotInfo [i] <= 26) {
				//solar
				solarMoney += SolarBuildings [(ButtonSlotInfo [i]-24), 0];
				solarPollution += CoalBuildings [(ButtonSlotInfo [i]-24), 1];
				solarEnergy += CoalBuildings [(ButtonSlotInfo [i]-24), 2];

			} else if (ButtonSlotInfo [i] >= 27 && ButtonSlotInfo [i] <= 29) {
				//farms
				farm1Money += FarmsBuildings [(ButtonSlotInfo [i]-27), 0];
				farm1Pollution += CoalBuildings [(ButtonSlotInfo [i]-27), 1];
				farm1Energy += CoalBuildings [(ButtonSlotInfo [i]-27), 2];

			} else if (ButtonSlotInfo [i] >= 30 && ButtonSlotInfo [i] <= 32) {
				//farms2
				farm2Money += Farms2Buildings [(ButtonSlotInfo [i]-30), 0];
				farm2Pollution += CoalBuildings [(ButtonSlotInfo [i]-30), 1];
				farm2Energy += CoalBuildings [(ButtonSlotInfo [i]-30), 2];

			} else if (ButtonSlotInfo [i] >= 33 && ButtonSlotInfo [i] <= 35) {
				//farms3
				farm3Money += Farms3Buildings [(ButtonSlotInfo [i]-33), 0];
				farm3Pollution += CoalBuildings [(ButtonSlotInfo [i]-33), 1];
				farm2Energy += CoalBuildings [(ButtonSlotInfo [i]-33), 2];

			} else {
				//template
			}
			//calculate social policy percent

			//globalMoney += UpgradeMoney [i];
			}
		globalMoney+=Moneyafterbonus();
	}
	public void setbuttons(int button,int set){
		ButtonSlotInfo [stage + button] = set;
	
	} 
	public int getBuildingMoney(int BuildingNum){
		
		return 0;
	}
	private void cleanEP(){
		CoalPollution=0; GeoPollution=0;nuclearPollution=0;oilPollution=0;hydroPollution=0;tidalPollution=0;gasPollution=0;windPollution=0;solarPollution=0;farm1Pollution=0;farm2Pollution=0;farm3Pollution=0;
		CoalEnergy=0; GeoEnergy=0;nuclearEnergy=0;oilEnergy=0;hydroEnergy=0;tidalEnergy=0;gasEnergy=0;windEnergy=0;solarEnergy=0;farm1Energy=0;farm2Energy=0;farm3Energy=0;
	}
	public int Moneyafterbonus(){
		TotalPol = 0;
		TotalEnergy = 0;
		if (keep.GetComponent<TechTreeKeeper> ().CoalPolicy (1) == 1) {
			int coalmoney;
			coalmoney = (CoalMoney + ((CoalMoney / 100) * 15));
			//TotalPol

			//TotalEnergy
			Debug.Log(coalmoney);
			TotalMoney +=coalmoney;

		}else{TotalMoney+=CoalMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().CoalPolicy (2) == 1) {
			int coalEnergy;
			coalEnergy = (CoalEnergy + ((CoalEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=coalEnergy;
			//TotalMoney 
		}else{TotalEnergy+=CoalEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().CoalPolicy (3) == 1) {
			int coalpol;
			coalpol = (CoalPollution - ((CoalPollution / 100) * 10));
			TotalPol+=coalpol;
			//TotalEnergy
			//TotalMoney
		}else{TotalPol+=CoalPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().GeoPolicy (1) == 1) {
			int geoEnergy;
			geoEnergy = (GeoEnergy + ((GeoEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=geoEnergy;
			//TotalMoney 
		}else{TotalEnergy+=GeoEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().GeoPolicy (2) == 1) {
			int geomoney;
			geomoney = (GeoMoney + ((GeoMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=geomoney;
		}else{TotalMoney+=GeoMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().GeoPolicy (3) == 1) {
			int Geopol;
			Geopol = (GeoPollution - ((GeoPollution / 100) * 10));
			TotalPol+=Geopol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=GeoPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().NuclearPolicy (1) == 1) {
			int nuclearpol;
			nuclearpol = (nuclearPollution - ((nuclearPollution / 100) * 10));
			TotalPol+=nuclearpol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=nuclearPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().NuclearPolicy (2) == 1) {
			int NuclearEnergy;
			NuclearEnergy = (nuclearEnergy + ((nuclearEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=NuclearEnergy;
			//TotalMoney 
		}else{TotalEnergy+=nuclearEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().NuclearPolicy (3) == 1) {
			int Nuclearmoney;
			Nuclearmoney = (nuclearMoney + ((nuclearMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=Nuclearmoney;
		}else{TotalMoney+=nuclearMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().OilPolicy (1) == 1) {
			int Oillearpol;
			Oillearpol = (oilPollution - ((oilPollution / 100) * 10));
			TotalPol+=Oillearpol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=oilPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().OilPolicy (2) == 1) {
			int OilEnergy;
			OilEnergy = (oilEnergy + ((oilEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=OilEnergy;
			//TotalMoney 
		}else{TotalEnergy+=oilEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().OilPolicy (3) == 1) {
			int Oilmoney;
			Oilmoney = (oilMoney + ((oilMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=Oilmoney;
		}else{TotalMoney+=oilMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().HydroPolicy (1) == 1) {
			int Hydropol;
			Hydropol = (hydroPollution - ((hydroPollution / 100) * 10));
			TotalPol+=Hydropol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=hydroPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().HydroPolicy (2) == 1) {
			int HydroEnergy;
			HydroEnergy = (hydroEnergy + ((hydroEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=HydroEnergy;
			//TotalMoney 
		}else{TotalEnergy+=hydroEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().HydroPolicy (3) == 1) {
			int Hydromoney;
			Hydromoney = (hydroMoney + ((hydroMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=Hydromoney;
		}else{TotalMoney+=hydroMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().TidalPolicy (1) == 1) {
			int Tidalpol;
			Tidalpol = (tidalPollution - ((tidalPollution / 100) * 10));
			TotalPol+=Tidalpol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=tidalPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().TidalPolicy (2) == 1) {
			int Tidalmoney;
			Tidalmoney = (tidalMoney + ((tidalMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=Tidalmoney;
		}else{TotalMoney+=tidalMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().TidalPolicy (3) == 1) {
			int TidalEnergy;
			TidalEnergy = (tidalEnergy + ((tidalEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=TidalEnergy;
			//TotalMoney 
		}else{TotalEnergy+=tidalEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().GasPolicy (1) == 1) {
			int pol;
			pol = (gasPollution - ((gasPollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=gasPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().GasPolicy (2) == 1) {
			int Energy;
			Energy = (gasEnergy + ((gasEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney 
		}else{TotalEnergy+=gasEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().GasPolicy (3) == 1) {
			int money;
			money = (gasMoney + ((gasMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=gasMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().WindPolicy (1) == 1) {
			int pol;
			pol = (windPollution - ((windPollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=windPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().WindPolicy (2) == 1) {
			int Energy;
			Energy = (windEnergy + ((windEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney 
		}else{TotalEnergy+=windEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().WindPolicy (3) == 1) {
			int money;
			money = (windMoney + ((windMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=windMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().SolarPolicy (1) == 1) {
			int pol;
			pol = (solarPollution - ((solarPollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=solarPollution;}
		if (keep.GetComponent<TechTreeKeeper> ().SolarPolicy (2) == 1) {
			int money;
			money = (solarMoney + ((solarMoney / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=solarMoney;}
		if (keep.GetComponent<TechTreeKeeper> ().SolarPolicy (3) == 1) {
			int Energy;
			Energy = (solarEnergy + ((solarEnergy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney 
		}else{TotalEnergy+=solarEnergy;}
		if (keep.GetComponent<TechTreeKeeper> ().FarmPolicy (1) == 1) {
			int pol;
			pol = (farm1Pollution - ((farm1Pollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=farm1Pollution;}
		if (keep.GetComponent<TechTreeKeeper> ().FarmPolicy (2) == 1) {
			int money;
			money = (farm1Money + ((farm1Money / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=farm1Money;}
		if (keep.GetComponent<TechTreeKeeper> ().FarmPolicy (3) == 1) {
			int Energy;
			Energy = (farm1Energy + ((farm1Energy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney 
		}else{TotalEnergy+=farm1Energy;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm2Policy (1) == 1) {
			int pol;
			pol = (farm2Pollution - ((farm2Pollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=farm2Pollution;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm2Policy (2) == 1) {
			int money;
			money = (farm2Money + ((farm2Money / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=farm2Money;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm2Policy (3) == 1) {
			int Energy;
			Energy = (farm2Energy + ((farm2Energy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney
		}else{TotalEnergy+=farm2Energy;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm3Policy (1) == 1) {
			int pol;
			pol = (farm3Pollution - ((farm3Pollution / 100) * 10));
			TotalPol+=pol;
			//TotalEnergy
			//TotalMoney 
		}else{TotalPol+=farm3Pollution;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm3Policy (2) == 1) {
			int money;
			money = (farm3Money + ((farm3Money / 100) * 15));
			//TotalPol
			//TotalEnergy
			TotalMoney +=money;
		}else{TotalMoney+=farm3Money;}
		if (keep.GetComponent<TechTreeKeeper> ().Farm3Policy (3) == 1) {
			int Energy;
			Energy = (farm3Energy + ((farm3Energy / 100) * 15));
			//TotalPol
			TotalEnergy+=Energy;
			//TotalMoney
		}else{TotalEnergy+=farm3Energy;}
		//Debug.Log (TotalMoney);
		return TotalMoney;
	
	}
}
