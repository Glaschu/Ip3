using UnityEngine;
using System.Collections;

public class ButtonMonitor : MonoBehaviour {
	public int[,] ButtonInfo = new int[,] { {  0, 2 }, //col 0   //stage 0    //{level,ButtonSlot,Upgrade}
									 {  1, 2 }, //col 1
									 {  2, 2 }, //col 2   //stageEnd 2  
									 {  0, 0 }, //col 3   //stage 3
									 {  1, 0 }, //col 4
								 	 {  2, 0 }, //col 5   //stageEnd 5  
									 {  0, 0 }, //col 6   //stage 6 
									 {  1, 0 }, //col 7
									 {  2, 0 }, //col 8   //stageEnd 8  
									 {  0, 0 }, //col 9   //stage 8 
									 {  1, 0 }, //col 10
		 							 {  2, 0 }, //col 11  //stageEnd 10  
									 {  0, 0 }, //col 12  //stage 12 
									 {  1, 0 }, //col 13
									 {  2, 0 }};//col 14  //stageEnd 14 
	int stage,stageEnd;

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
		}
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
}
