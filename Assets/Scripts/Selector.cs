using UnityEngine;
using System.Collections;

public class Selector : MonoBehaviour {
	public GameObject Tile;
	public GameObject lastTile;
	int p =0;
	public Sprite test1;
	public Sprite test2;
	public Sprite test3;
	public Sprite test4;
	private SpriteRenderer spriteRenderer;
	public GameObject powerMenu;
	// Use this for initialization
	void Start () {
		//spriteRenderer = GetComponent<SpriteRenderer>();
		//powerMenu = GameObject.Find("powerMenu");
		lastTile=GameObject.Find("Tile00");
	}
	
	// Update is called once per frame
	void Update () {
		if (p == 0) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
			//RaycastHit hit = Physics.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider != null) {
					string name = hit.transform.gameObject.name;
					Tile = GameObject.Find (name);

					Tile.transform.GetChild (0).gameObject.SetActive (true);
					//lastTile=Tile;
					if (lastTile != Tile) {
						lastTile.transform.GetChild (0).gameObject.SetActive (false);
						lastTile = Tile;
					}


				}
			}
			if (Input.GetMouseButton (0) & hit.collider != null) {
				p=1;

				powerMenu.SetActive(true);
			
			}
		}
	}

	public void changeTile(int newtile){
		spriteRenderer=Tile.GetComponent<SpriteRenderer>();
		//spriteRenderer.sprite=test1;
		switch (newtile)
		{
		case 1:
			spriteRenderer.sprite=test1;
			break;
		case 2:
			spriteRenderer.sprite=test2;
			break;
		case 3:
			spriteRenderer.sprite=test3;
			break;
		case 4:
			spriteRenderer.sprite=test4;
			break;
		default:
			spriteRenderer.sprite=test1;
			break;
		}
		p = 0;
		powerMenu.SetActive(false);

	}
}
