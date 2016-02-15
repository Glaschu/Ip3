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
	public int buttonClicked =0;
	public int updateClicked=0;
	public Button clickedName1,clickedName2,clickedName3;
	int count =0;
	// Use this for initialization
	void Start () {
		

	}
	void Awake(){
	textures=Resources.LoadAll<Sprite>("Buttons");
		keep = GameObject.Find("Keeper");
		if (keep == null) {
			Debug.LogError("keep Loading Error");

		}
		}
	
	
	
	// Update is called once per frame
	void Update () {
		if (keep == null) {
			keep = GameObject.Find("Keeper");
			count +=1;
			Debug.LogError(count);
		}
	}

	public void OnButtonClick(int select){
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
		keep.GetComponent<ButtonMonitor> ().UpgradeArray (buttonClicked, updateClicked);
		ChangeTex (buttonClicked, updateClicked);
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
			default:
				clickedName1.image.sprite = textures[0];
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
			default:
				clickedName2.image.sprite = textures[0];
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
			default:
				clickedName3.image.sprite = textures[0];
				break;
			}

		}

	}
}
	