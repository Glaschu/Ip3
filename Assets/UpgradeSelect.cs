using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UpgradeSelect : MonoBehaviour {
	public GameObject PopUp;
	public GameObject MoneyPopUp;
	public GameObject RePopUp;
	public GameObject OwnedPopUp;
	public Text Money;
	public Text Time;
	public Text Info;
	public int hexSelected = 0;
	public int hexInSelected;
	public GameObject keep;
	bool NotOwned;

	public int[,] GeoPrice     	= new int[,] {{  140000, 4 },{  100000, 0 }, {  130000, 3 }, { 100000, 0 }, {  100000, 3 }, {  100000, 0 } };//price,time every year = 1
	public int[,] CoalPrice     = new int[,] {{  30000, 3 },{  100000, 0 }, {  25000, 2 }, { 100000, 0 }, {  0, 1 }, { 100000, 0 } };
	public int[,] NuclearPrice  = new int[,] {{ 100000, 0 },{ 1000000, 6 }, { 100000, 0 }, { 750000, 5 }, { 100000, 0 }, {  250000, 4 } };
	public int[,] OilPrice      = new int[,] {{  0, 1 },{  100000, 0 }, {  40000, 3 }, { 100000, 0 }, {  50000, 5 }, {  100000, 0 } };
	public int[,] HydroPrice    = new int[,] {{  100000, 4 },{  100000, 0 }, {  150000, 5 }, {  100000, 0 }, {  200000, 6 }, { 100000, 0 } };
	public int[,] TidalPrice    = new int[,] {{  50000, 3 },{ 100000, 0 }, {  25000, 4 }, { 100000, 0 }, {  45000, 5 }, { 100000, 0 } };
	public int[,] GasPrice      = new int[,] {{  0, 1 },{ 100000, 0 }, {  30000, 3 }, { 100000, 0 }, {  60000, 4 }, { 100000, 0 } };
	public int[,] SolarPrice    = new int[,] {{  40000, 4 },{  100000, 0 }, {  70000, 4 }, {  100000, 0 }, {  35000, 0 }, { 100000, 0 } };
	public int[,] WindPrice     = new int[,] {{  50000, 3 },{  100000, 0 }, {  100000, 4 }, { 100000, 0 }, {  125000, 5 }, {  100000, 0 } };
	public int[,] FarmsPrice    = new int[,] {{  0, 1 },{  100000, 0 }, {  125000, 2 }, {  100000, 0 }, {  150000, 3 }, { 100000, 0 } };
	public int[,] Farms2Price   = new int[,] {{  170000, 4 },{ 100000, 0 }, {  200000, 5 }, { 100000, 0 }, {  250000, 6 }, { 100000, 0 } };
	public int[,] Farms3Price   = new int[,] {{  300000, 7 },{ 100000, 0 }, {  325000, 8 }, {  100000, 0 }, {  350000, 9 }, {  100000, 0 } };
	void Awake () {
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		keep = GameObject.Find("Keeper");
	}

	// Update is called once per frame
	void Update () {

	}
	public void ExitPop(){
		PopUp.SetActive (false);
		hexSelected = 0;
		hexInSelected=0;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
	}
	public void CoalUpdate(int Slot){
		hexSelected = 1;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£30,000"); //3 Building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 90  \n Pollution Output: 70 \n Currency Output: £20,000");
			break;
		case 1:
			Money.text = ("£100,000"); //3 Social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Coal Reduced by 10%");
			break;
		case 2:
			Money.text = ("£25,000"); //2 Building
			Time.text =("2 Years to complete");
			Info.text =("Energy Output: 75  \n Pollution Output: 65 \n Currency Output: £10,000");
			break;
		case 3: 
			Money.text = ("£100,000"); //2 Social
			Time.text =("Immediate");
			Info.text =("Energy Output of Coal increased by 15%");
			break;
		case 4:
			Money.text = ("FREE"); //1 Building
			Time.text =("1 Year to complete");
			Info.text =("Energy Output: 60  \n Pollution Output: 60 \n Currency Output: £5,000");
			break;
		case 5:
			Money.text = ("£100,000"); //1 Social
			Time.text =("Immediate");
			Info.text =("Currency Output of Coal increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void GeoUpdate(int Slot){
		hexSelected = 2;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£140,000"); //3 Building
			Time.text =("4 Years");
			Info.text =("Energy Output: 70  \n Pollution Output: 0 \n Currency Output: £7,000");
			break;
		case 1:
			Money.text = ("£100,000"); //2 social
			Time.text =("Immediate");
			Info.text =("Pollution output of Geothermal reduced by 10%");
			break;
		case 2:
			Money.text = ("£130,000"); //2 Building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 60  \n Pollution Output: 5 \n Currency Output: £6,000");
			break;
		case 3:
			Money.text = ("£100,000"); //1 social
			Time.text =("Immediate");
			Info.text =("Energy Output of Geothermal increased by 15%");
			break;
		case 4:
			Money.text = ("£100,000"); //1 Building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 50  \n Pollution Output: 10 \n Currency Output: £5,000");
			break;
		case 5:
			Money.text = ("£100,000"); // 3 social
			Time.text =("Immediate");
			Info.text =("Currency Output of Geothermal increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void NuclearUpdate(int Slot){
		hexSelected = 3;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£100,000"); //1st social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Nuclear is decreased by 10%");
			break;
		case 1:
			Money.text = ("£1,000,000"); //3 Building
			Time.text =("6 Years");
			Info.text =("Energy Output: 500  \n Pollution Output: 0 \n Currency Output: £17,000");
			break;
		case 2:
			Money.text = ("£100,000");   //3rd Social
			Time.text =("Immediate");
			Info.text =("Currency Output of Nuclear is increased by 15%");
			break;
		case 3:

			Money.text = ("£750,000"); //2 Building
			Time.text =("5 Years");
			Info.text =("Energy Output: 300  \n Pollution Output: 10 \n Currency Output: £10,000");
			break;
		case 4:
			Money.text = ("£100,000"); //2nd Social 
			Time.text =("Immediate");
			Info.text =("Energy Output of Nuclear is increased by 15%");
			break;
		case 5:
			Money.text = ("£250,000"); //1 Building
			Time.text =("4 Years");
			Info.text =("Energy Output: 200  \n Pollution Output: 20 \n Currency Output: £7,500");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void OilUpdate(int Slot){
		hexSelected = 4;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("FREE"); //1 Building
			Time.text =("1 Year to complete");
			Info.text =("Energy Output: 60  \n Pollution Output: 60 \n Currency Output: £20,000");
			break;
		case 1:
			Money.text = ("£100,000"); //1st Social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Oil  is decreased by 10%");
			break;
		case 2:
			Money.text = ("£40,000"); //2 Building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 70  \n Pollution Output: 65 \n Currency Output: £40,000");
			break;
		case 3:

			Money.text = ("£100,000"); //2nd Social
			Time.text =("Immediate");
			Info.text =("Energy Output of Oil is increased by 15%");
			break;
		case 4:
			Money.text = ("£50,000"); //3 Building
			Time.text =("5 Years to complete");
			Info.text =("Energy Output: 80  \n Pollution Output: 70 \n Currency Output: £20,000");
			break;
		case 5:
			Money.text = ("£100,000"); //3rd Social
			Time.text =("Immediate");
			Info.text =("Currency Output of Oil is increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void TidalUpdate(int Slot){
		hexSelected = 5;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£50,000"); //1 Building 
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 25  \n Pollution Output: 10 \n Currency Output: £5,000");
			break;
		case 1:
			Money.text = ("£100,000"); // 2rd social
			Time.text =("Immediate");
			Info.text =("Currency Output of Tidal is increased by 15%");
			break;
		case 2:
			Money.text = ("£25,000"); //2 Building
			Time.text =("4 Years");
			Info.text =("Energy Output: 35  \n Pollution Output: 5 \n Currency Output: £7,500");
			break;
		case 3:


			Money.text = ("£100,000"); //3 social
			Time.text =("Immediate");
			Info.text =("Energy Output of Tidal is increased by 15%");
			break;
		case 4:
			Money.text = ("£45,000"); //3 Building
			Time.text =("5 Years to complete");
			Info.text =("Energy Output: 40  \n Pollution Output: 5 \n Currency Output: £10,000");
			break;
		case 5:
			Money.text = ("£100,000"); //1st social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Tidal is decreased by 10%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void HydroUpdate(int Slot){
		hexSelected = 6;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£100,000"); // 1 Building
			Time.text =("4 Years to complete");
			Info.text =("Energy Output: 100  \n Pollution Output: 10 \n Currency Output: £5,000");
			break;
		case 1:
			Money.text = ("£100,000"); //1st social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Hydro is decreased by 10%");
			break;
		case 2:
			Money.text = ("£150,000"); //2 Building
			Time.text =("5 Years");
			Info.text =("Energy Output: 120  \n Pollution Output: 5 \n Currency Output: £10,000");
			break;
		case 3:

			Money.text = ("£100,000"); //2nd social
			Time.text =("Immediate");
			Info.text =("Energy Output of Hydro is increased by 15%");
			break;
		case 4:
			Money.text = ("£200,000"); //3 Building
			Time.text =("6 Years");
			Info.text =("Energy Output: 200  \n Pollution Output: 0 \n Currency Output: £12,500");
			break;
		case 5:
			Money.text = ("£100,000"); //3rd social
			Time.text =("Immediate");
			Info.text =("Currency Output of Hydro is increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void GasUpdate(int Slot){
		hexSelected = 7;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("FREE");  //2 Building
			Time.text =("1 year to complete");
			Info.text =("Energy Output: 70  \n Pollution Output: 50 \n Currency Output: £10,000");
			break;
		case 1:
			Money.text = ("£100,000"); //1 social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Gas is decreased by 10%");
			break;
		case 2:
			Money.text = ("£30,000"); //1 Building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 75  \n Pollution Output: 60 \n Currency Output: £20,000");
			break;
		case 3:

			Money.text = ("£100,000"); //2 Social
			Time.text =("Immediate"); 
			Info.text =("Energy Output of Gas is increased by 15%");
			break;
		case 4:
			Money.text = ("£60,000"); //3 Building
			Time.text =("4 Years to complete");
			Info.text =("Energy Output: 80  \n Pollution Output: 75 \n Currency Output: £20,000");
			break;
		case 5:
			Money.text = ("£100,000"); // 3 Social
			Time.text =("Immediate");
			Info.text =("Currency Output of Gas is increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void WindUpdate(int Slot){
		hexSelected = 8;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£50,000"); //1 building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 25  \n Pollution Output: 10 \n Currency Output: £1,000");
			break;
		case 1:
			Money.text = ("£100,000");
			Time.text =("Immediate"); //1st social
			Info.text =("Pollution Output of Wind is decreased by 10%");
			break;
		case 2:
			Money.text = ("£100,000"); //2 building
			Time.text =("4 Years to complete");
			Info.text =("Energy Output: 35 \n Pollution Output: 5 \n Currency Output: £2,000");
			break;
		case 3:

			Money.text = ("£100,000"); //2nd social
			Time.text =("Immediate");
			Info.text =("Energy Output of Wind is increased by 15%");
			break;
		case 4:
			Money.text = ("£125,000"); // 3 building
			Time.text =("5 Years to complete");
			Info.text =("Energy Output: 50  \n Pollution Output: 0 \n Currency Output: £5,000");
			break;
		case 5:
			Money.text = ("£100,000"); //3 social
			Time.text =("Immediate");
			Info.text =("Currency Output of Wind is increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void SolarUpdate(int Slot){
		hexSelected = 9;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£40,000"); //2 building
			Time.text =("4 Years to complete");
			Info.text =("Energy Output: 60  \n Pollution Output: 5 \n Currency Output: £2,000");
			break;
		case 1:
			Money.text = ("£100,000");  //1 social
			Time.text =("Immediate");
			Info.text =("Pollution Output of Solar is decreased by 10%");
			break;
		case 2:
			Money.text = ("£70,000"); // 1 building
			Time.text =("3 Years to complete");
			Info.text =("Energy Output: 30   \n Pollution Output: 10 \n Currency Output: £3,000");
			break;
		case 3:


			Money.text = ("£100,000"); //3 social
			Time.text =("Immediate");
			Info.text =("Energy Output of Solar is increased by 15%");
			break;
		case 4:
			Money.text = ("£35,000"); //3 building
			Time.text =("5 Years");
			Info.text =("Energy Output: 80  \n Pollution Output: 0 \n Currency Output: £4,000");
			break;
		case 5:
			Money.text = ("£100,000"); //2 Social
			Time.text =("Immediate");
			Info.text =("Currency Output of Solar is increased by 15%");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void FarmsUpdate(int Slot){
		hexSelected = 10;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("FREE");
			Time.text =("1 Year");
			Info.text =("Energy Output: 0  \n Pollution Output: -10 \n Currency Output: £30,000");
			break;
		case 1:
			Money.text = ("£100,000");
			Time.text =("Immediate");
			Info.text =("Pollution reduction output from farms is increased by 20%");
			break;
		case 2:
			Money.text = ("£125,000");
			Time.text =("2 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -15 \n Currency Output: £40,000");
			break;
		case 3:
			Money.text = ("£100,000");
			Time.text =("Immediate");
			Info.text =("Currency Output of farms is increased by 15%");
			break;
		case 4:
			Money.text = ("£150,000");
			Time.text = ("3 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -20 \n Currency Output: £50,000");
			break;
		case 5:
			Money.text = ("N/A");
			Time.text =("N/A");
			Info.text =("N/A");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void Farms2Update(int Slot){
		hexSelected = 11;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£170,000");
			Time.text =("4 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -25 \n Currency Output: £70,000");
			break;
		case 1:
			Money.text = ("£100,000");
			Time.text =("Immediate");
			Info.text =("N/A");
			break;
		case 2:
			Money.text = ("£200,000");
			Time.text =("5 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -40 \n Currency Output: £90,000");
			break;
		case 3:
			Money.text = ("£100,000");
			Time.text =("Immediate");
			Info.text =("N/A");
			break;
		case 4:
			Money.text = ("£250,000");
			Time.text =("6 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -60 \n Currency Output: £110,000");
			break;
		case 5:
			Money.text = ("N/A");
			Time.text =("N/A");
			Info.text =("N/A");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}
	public void Farms3Update(int Slot){
		hexSelected = 12;
		OwnedPopUp.SetActive(false);
		MoneyPopUp.SetActive(false);
		RePopUp.SetActive(false);
		hexInSelected = Slot;
		switch (Slot)
		{
		case 0:
			Money.text = ("£300,000");
			Time.text =("7 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -90 \n Currency Output: £160,000");
			break;
		case 1:
			Money.text = ("N/A");
			Time.text =("N/A");
			Info.text =("N/A");
			break;
		case 2:
			Money.text = ("£325,000");
			Time.text =("8 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -120 \n Currency Output: £200,000");
			break;
		case 3:
			Money.text = ("N/A");
			Time.text =("N/A");
			Info.text =("N/A");
			break;
		case 4:
			Money.text = ("£350,000");
			Time.text =("9 Years");
			Info.text =("Energy Output: 0  \n Pollution Output: -200 \n Currency Output: £230,000");
			break;
		case 5:
			Money.text = ("N/A");
			Time.text =("N/A");
			Info.text =("N/A");
			break;
		default:
			Money.text = ("1 billion");
			Time.text =("1 billion");
			Info.text =("update info");
			break;
		}
		PopUp.SetActive(true);
	}


	public void BuyTech ()
	{
		switch (hexSelected)
		{
		case 0:

			break;
		case 1:
			if (keep.GetComponent<TechTreeKeeper> ().getCoal(hexInSelected) == 1) {
				NotOwned = false;
			} else {NotOwned = true;}
			break;
		case 2:
			if (keep.GetComponent<TechTreeKeeper> ().getGeo(hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 3:
			if (keep.GetComponent<TechTreeKeeper> ().getNuclear (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 4:
			if (keep.GetComponent<TechTreeKeeper> ().getOil (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 5:
			if (keep.GetComponent<TechTreeKeeper> ().getTidal (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 6:
			if (keep.GetComponent<TechTreeKeeper> ().getHydro (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 7:
			if (keep.GetComponent<TechTreeKeeper> ().getGas (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 8:
			if (keep.GetComponent<TechTreeKeeper> ().getWind (hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 9:
			if (keep.GetComponent<TechTreeKeeper> ().getSolar(hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 10:
			if (keep.GetComponent<TechTreeKeeper> ().getFarms(hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 11:
			if (keep.GetComponent<TechTreeKeeper> ().getFarms2(hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;
		case 12:
			if (keep.GetComponent<TechTreeKeeper> ().getFarms3(hexInSelected) == 1) {
				NotOwned = false;
			}else {NotOwned = true;}
			break;

		default:

			break;
		}

		if (keep.GetComponent<Scores> ().researchable && NotOwned) {
			if (hexSelected == 1) {
				if (CoalPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= CoalPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().CoalInfo [hexInSelected] = 1;
					if (CoalPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setCoal (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = CoalPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}
			} else if (hexSelected == 2) {
				if (GeoPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= GeoPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().GeoInfo [hexInSelected] = 1;
					if (GeoPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setGeo (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = GeoPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 3) {
				if (NuclearPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= NuclearPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().NuclearInfo [hexInSelected] = 1;
					if (NuclearPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setNuclear (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = NuclearPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 4) {
				if (OilPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= OilPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().OilInfo [hexInSelected] = 1;
					if (OilPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setOil (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = OilPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 5) {
				if (TidalPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= TidalPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().TidalInfo [hexInSelected] = 1;
					if (TidalPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setTidal (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = TidalPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 6) {
				if (HydroPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= HydroPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().HydroInfo [hexInSelected] = 1;
					if (HydroPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setHydro (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = HydroPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 7) {
				if (GasPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= GasPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().GasInfo [hexInSelected] = 1;
					if (GasPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setGas (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = GasPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}

				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 8) {
				if (WindPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= WindPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().WindInfo [hexInSelected] = 1;
					if (WindPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setWind (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = WindPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 9) {
				if (SolarPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= SolarPrice [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().SolarInfo [hexInSelected] = 1;
					if (SolarPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setSolar (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = SolarPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 10) {
				if (FarmsPrice [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= FarmsPrice [hexInSelected, 0];
					if (FarmsPrice [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setFarms (hexInSelected);
					} else {
						//keep.GetComponent<TechTreeKeeper> ().FarmsInfo [hexInSelected] = 1;
						keep.GetComponent<Scores> ().Upgradetime = FarmsPrice [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 11) {
				if (Farms2Price [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= Farms2Price [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().Farms2Info [hexInSelected] = 1;
					if (Farms2Price [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setFarms2 (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = Farms2Price [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			} else if (hexSelected == 12) {
				if (Farms3Price [hexInSelected, 0] <= keep.GetComponent<ButtonMonitor> ().globalMoney) {
					keep.GetComponent<ButtonMonitor> ().globalMoney -= Farms3Price [hexInSelected, 0];
					//keep.GetComponent<TechTreeKeeper> ().Farms2Info [hexInSelected] = 1;
					if (Farms3Price [hexInSelected, 1] == 0) {
						keep.GetComponent<TechTreeKeeper> ().setFarms3 (hexInSelected);
					} else {
						keep.GetComponent<Scores> ().Upgradetime = Farms3Price [hexInSelected, 1];
						keep.GetComponent<Scores> ().hex = hexSelected;
						keep.GetComponent<Scores> ().hexIn = hexInSelected;
					}
				} else {
					MoneyPopUp.SetActive(true);
				}

			}
		} else {
			if(NotOwned==false){
				OwnedPopUp.SetActive(true);
				//MoneyPopUp.SetActive(true);
				//RePopUp.SetActive(true);
			Debug.Log("owned");}else{



				RePopUp.SetActive(true);
				Debug.Log ("research");
			}
			//close box
		}
	}
}
