using UnityEngine;
using System.Collections;

public class TechTreeKeeper : MonoBehaviour {
									//B3 S2 B2 S1 B1 S3
	public int[] GeoInfo = new int[] { 0, 0, 0, 0, 0, 0 };//1 means unlocked
								
	private int[] GeoInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B3 S3 B2 S2 B1 S1
	public int[] CoalInfo = new int[] { 0, 0, 0, 0, 0, 0 };
										
	private int[] CoalInfo2 = new int[] { 0, 0, 0, 0, 1, 0 };
										//s1b3s3b2s2b1
										//B1 S3 B3 S2 B2 S1
	public int[] NuclearInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] NuclearInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B1 S1 B2 S2 B3 S3
	public int[] OilInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] OilInfo2 = new int[] { 1, 0, 0, 0, 0, 0 };
										//B1 S1 B2 S2 B3 S3
	public int[] HydroInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] HydroInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B1 S2 B2 S3 B3 S1
	public int[] TidalInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] TidalInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B2 S1 B1 S3 B3 S2
	public int[] GasInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] GasInfo2 = new int[] { 0, 0, 1, 0, 0, 0 };

										//B1 S1 B2 S2 B3 S3
	public int[] WindInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] WindInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B2 S1 B1 S3 B3 S2
	public int[] SolarInfo = new int[] { 0, 0, 0, 0, 0, 0 };
	private int[] SolarInfo2 = new int[] { 0, 0, 0, 0, 0, 0 };

										//B1 S1 B2 S2 B3 S3
	public int[] FarmsInfo = new int[] {0, 0, 0, 0, 0, 0 };
	private int[] FarmsInfo2 = new int[] {1, 0, 0, 0, 0, 0 };
						
										//B1 S1 B2 S2 B3 S3
	public int[] Farms2Info = new int[] {0,0,0,0,0,0};
	private int[] Farms2Info2 = new int[] {0,0,0,0,0,0};

										//B1 S1 B2 S2 B3 S3
	public int[] Farms3Info = new int[] {0,0,0,0,0,0};
	private int[] Farms3Info2 = new int[] {0,0,0,0,0,0};



	public int Money;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public int getCoal (int hexIn){
		int got = CoalInfo2 [hexIn];
		return got;
	}
	public int getGeo (int hexIn){
		int got = GeoInfo2 [hexIn];
		return got;
	}
	public int getNuclear (int hexIn){
		int got = NuclearInfo2 [hexIn];
		return got;
	}
	public int getOil (int hexIn){
		int got = OilInfo2 [hexIn];
		return got;
	}
	public int getTidal (int hexIn){
		int got = TidalInfo2 [hexIn];
		return got;
	}
	public int getHydro (int hexIn){
		int got = HydroInfo2 [hexIn];
		return got;
	}
	public int getGas (int hexIn){
		int got = GasInfo2 [hexIn];
		return got;
	}
	public int getWind (int hexIn){
		int got = WindInfo2 [hexIn];
		return got;
	}
	public int getSolar (int hexIn){
		int got = SolarInfo2 [hexIn];
		return got;
	}
	public int getFarms (int hexIn){
		int got = FarmsInfo2 [hexIn];
		return got;
	}
	public int getFarms2 (int hexIn){
		int got = Farms2Info2 [hexIn];
		return got;
	}
	public int getFarms3 (int hexIn){
		int got = Farms3Info2 [hexIn];
		return got;
	}


	public void setCoal (int hexIn){
		CoalInfo2 [hexIn] = 1;
	}
	public void setGeo (int hexIn){
		GeoInfo2 [hexIn] = 1;
	}
	public void setNuclear (int hexIn){
		NuclearInfo2 [hexIn] = 1;
	}
	public void setOil (int hexIn){
		OilInfo2 [hexIn] = 1;
	}
	public void setTidal (int hexIn){
		TidalInfo2 [hexIn] = 1;
	}
	public void setHydro (int hexIn){
		HydroInfo2 [hexIn] = 1;
	}
	public void setGas (int hexIn){
		GasInfo2 [hexIn] = 1;
	}
	public void setWind (int hexIn){
		WindInfo2 [hexIn] = 1;
	}
	public void setSolar (int hexIn){
		SolarInfo2 [hexIn] = 1;
	}
	public void setFarms (int hexIn){
		FarmsInfo2 [hexIn] = 1;
	}
	public void setFarms2 (int hexIn){
		Farms2Info2 [hexIn] = 1;
	}
	public void setFarms3 (int hexIn){
		Farms3Info2 [hexIn] = 1;
	}

	public int CoalPolicy(int num){
		if (num == 1) {
			return CoalInfo2 [5];
		} else if (num == 2) {
			return CoalInfo2 [3];
		} else if (num == 3) {
			return CoalInfo2 [1];
		}
		return 0;
	}
	public int GeoPolicy(int num){
		if (num == 1) {
			return GeoInfo2 [3];
		} else if (num == 2) {
			return GeoInfo2 [1];
		} else if (num == 3) {
			return GeoInfo2 [5];
		}
		return 0;
	}
	public int NuclearPolicy(int num){
		if (num == 1) {
			return NuclearInfo2 [0];
		} else if (num == 2) {
			return NuclearInfo2 [4];
		} else if (num == 3) {
			return NuclearInfo2 [2];
		}
		return 0;
	}
	public int OilPolicy(int num){
		if (num == 1) {
			return OilInfo2 [1];
		} else if (num == 2) {
			return OilInfo2 [3];
		} else if (num == 3) {
			return OilInfo2 [5];
		}
		return 0;
	}
	public int HydroPolicy(int num){
		if (num == 1) {
			return HydroInfo2 [1];
		} else if (num == 2) {
			return HydroInfo2 [3];
		} else if (num == 3) {
			return HydroInfo2 [5];
		}
		return 0;
	}
	public int TidalPolicy(int num){
		if (num == 1) {
			return TidalInfo2 [5];
		} else if (num == 2) {
			return TidalInfo2 [1];
		} else if (num == 3) {
			return TidalInfo2 [3];
		}
		return 0;
	}

	public int GasPolicy(int num){
		if (num == 1) {
			return GasInfo2 [1];
		} else if (num == 2) {
			return GasInfo2 [5];
		} else if (num == 3) {
			return GasInfo2 [3];
		}
		return 0;
	}
	public int WindPolicy(int num){
		if (num == 1) {
			return WindInfo2 [1];
		} else if (num == 2) {
			return WindInfo2 [3];
		} else if (num == 3) {
			return WindInfo2 [5];
		}
		return 0;
	}
	public int SolarPolicy(int num){
		if (num == 1) {
			return SolarInfo2 [1];
		} else if (num == 2) {
			return SolarInfo2 [5];
		} else if (num == 3) {
			return SolarInfo2 [3];
		}
		return 0;
	}
	public int FarmPolicy(int num){
		if (num == 1) {
			return FarmsInfo2 [1];
		} else if (num == 2) {
			return FarmsInfo2 [3];
		} else if (num == 3) {
			return FarmsInfo2 [5];
		}
		return 0;
	}
	public int Farm2Policy(int num){
		if (num == 1) {
			return Farms2Info2 [1];
		} else if (num == 2) {
			return Farms2Info2 [3];
		} else if (num == 3) {
			return Farms2Info2 [5];
		}
		return 0;
	}
	public int Farm3Policy(int num){
		if (num == 1) {
			return Farms3Info2 [1];
		} else if (num == 2) {
			return Farms3Info2 [3];
		} else if (num == 3) {
			return Farms3Info2 [5];
		}
		return 0;
	}


	public int CoalBuilding(int num){
		if (num == 1) {
			return CoalInfo2 [4];
		} else if (num == 2) {
			return CoalInfo2 [2];
		} else if (num == 3) {
			return CoalInfo2 [0];
		}
		return 0;
	}
	public int GeoBuilding(int num){
		if (num == 1) {
			return GeoInfo2 [4];
		} else if (num == 2) {
			return GeoInfo2 [2];
		} else if (num == 3) {
			return GeoInfo2 [0];
		}
		return 0;
	}
	public int NuclearBuilding(int num){
		if (num == 1) {
			return NuclearInfo2 [5];
		} else if (num == 2) {
			return NuclearInfo2 [3];
		} else if (num == 3) {
			return NuclearInfo2 [1];
		}
		return 0;
	}
	public int OilBuilding(int num){
		if (num == 1) {
			return OilInfo2 [0];
		} else if (num == 2) {
			return OilInfo2 [2];
		} else if (num == 3) {
			return OilInfo2 [4];
		}
		return 0;
	}
	public int HydroBuilding(int num){
		if (num == 1) {
			return HydroInfo2 [0];
		} else if (num == 2) {
			return HydroInfo2 [2];
		} else if (num == 3) {
			return HydroInfo2 [4];
		}
		return 0;
	}
	public int TidalBuilding(int num){
		if (num == 1) {
			return TidalInfo2 [0];
		} else if (num == 2) {
			return TidalInfo2 [2];
		} else if (num == 3) {
			return TidalInfo2 [4];
		}
		return 0;
	}

	public int GasBuilding(int num){
		if (num == 1) {
			return GasInfo2 [2];
		} else if (num == 2) {
			return GasInfo2 [0];
		} else if (num == 3) {
			return GasInfo2 [4];
		}
		return 0;
	}
	public int WindBuilding(int num){
		if (num == 1) {
			return WindInfo2 [0];
		} else if (num == 2) {
			return WindInfo2 [2];
		} else if (num == 3) {
			return WindInfo2 [4];
		}
		return 0;
	}
	public int SolarBuilding(int num){
		if (num == 1) {
			return SolarInfo2 [2];
		} else if (num == 2) {
			return SolarInfo2 [0];
		} else if (num == 3) {
			return SolarInfo2 [4];
		}
		return 0;
	}
	public int FarmBuilding(int num){
		if (num == 1) {
			return FarmsInfo2 [0];
		} else if (num == 2) {
			return FarmsInfo2 [2];
		} else if (num == 3) {
			return FarmsInfo2 [4];
		}
		return 0;
	}
	public int Farm2Building(int num){
		if (num == 1) {
			return Farms2Info2 [0];
		} else if (num == 2) {
			return Farms2Info2 [2];
		} else if (num == 3) {
			return Farms2Info2 [4];
		}
		return 0;
	}
	public int Farm3Building(int num){
		if (num == 1) {
			return Farms3Info2 [0];
		} else if (num == 2) {
			return Farms3Info2 [2];
		} else if (num == 3) {
			return Farms3Info2 [4];
		}
		return 0;
	}
}
