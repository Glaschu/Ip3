using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Menus : MonoBehaviour {
	private Sprite[] textures;
	public GameObject UpgradeMenu;
	public int buttonClicked =0;
	public int updateClicked=0;
	public Button clickedName1,clickedName2,clickedName3;
	// Use this for initialization
	void Start () {
		textures=Resources.LoadAll<Sprite>("Buttons");
	}
	
	// Update is called once per frame
	void Update () {
		if (buttonClicked == 1) {
			switch (updateClicked)
			{
			case 1:
				clickedName1.image.sprite = textures[0];
				break;
			case 2:
				clickedName1.image.sprite = textures[1];
				break;
			case 3:
				clickedName1.image.sprite = textures[2];
				break;
			default:
				clickedName1.image.sprite = textures[0];
				break;
			}

		}else if (buttonClicked == 2) {
			switch (updateClicked)
			{
			case 1:
				clickedName2.image.sprite = textures[0];
				break;
			case 2:
				clickedName2.image.sprite = textures[1];
				break;
			case 3:
				clickedName2.image.sprite = textures[2];
				break;
			default:
				clickedName2.image.sprite = textures[0];
				break;
			}

		}else if (buttonClicked == 3) {
			switch (updateClicked)
			{
			case 1:
				clickedName3.image.sprite = textures[0];
				break;
			case 2:
				clickedName3.image.sprite = textures[1];
				break;
			case 3:
				clickedName3.image.sprite = textures[2];
				break;
			default:
				clickedName3.image.sprite = textures[0];
				break;
			}

		}

	}

	public void OnButtonClick(int select){
		UpgradeMenu.SetActive(true);
		buttonClicked = select;
		updateClicked = 0;
	}
	public void OnUpgradeButtonClick(int select){
		updateClicked = select;
		UpgradeMenu.SetActive(false);
	}
}
	