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
	public int city1Money,city2Money,city3Money,city4Money,city5Money;
	public int research;

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

	 GameObject keep,level;
	//int slotClicked,SlotUpdate;
	// Use this for initialization
	void Start () {
		keep = GameObject.Find("Keeper");
	}
	
	// Update is called once per frame
	void Update () { 
		if (Input.GetKeyDown (KeyCode.A)) {
			TestButtons ();
			calculate ();
		}
		if (Input.GetKeyDown(KeyCode.Q))
			Application.Quit();
	}


	void OnLevelWasLoaded(int level) {
		if (level > 0) {
			keep.gameObject.tag="Keeper";
		}

		if (level == 1){
			stage = 0;
			stageEnd = 2;

			LoadButtons ();

		}
		else if(level == 2){
			stage = 3;
			stageEnd=5;
			LoadButtons ();
		}
		

	}
	void LoadButtons(){


		level = GameObject.Find ("Management");
		for (int i = stage; i <= stageEnd; i++) {
			{

				int buttonslot = ButtonInfo[i,0];
				int upgrade = ButtonInfo[i,1];
				//level.GetComponent<Menus> ().ChangeTex (2,3);
				level.GetComponent<Menus> ().ChangeTex (buttonslot,upgrade);

					 


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
					Debug.Log ("5");
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
}
