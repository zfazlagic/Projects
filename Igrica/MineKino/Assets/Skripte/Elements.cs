using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elements : MonoBehaviour
    {

	public GameObject mainPanel;
    // varijabla koja je true ako je mina, false u suprotnom
    public bool mine;

	public void displayMenu()
	{
		mainPanel.GetComponent<CanvasGroup> ().interactable = true;
		mainPanel.GetComponent<CanvasGroup> ().alpha = 1;
	}

	public void hideMenu()
	{
		mainPanel.GetComponent<CanvasGroup> ().interactable = false;
		mainPanel.GetComponent<CanvasGroup> ().alpha = 0;
	}

	public void ponovi()
	{
		Application.LoadLevel ("GameScene");
	}

	public void exit()
	{
		Application.LoadLevel ("MenuScena");
	}

    // Ostale teksture
    public Sprite[] emptyTextures;
    public Sprite mineTexture;

    // Use this for initialization
    void Start ()
        {
		// Random odabir mine 15% sansa
		mine = Random.value < 0.15;
		// test loadTexture(1);

		// Postavljanje matrice
		int x = (int)transform.position.x;
		int y = (int)transform.position.y;
		Grid.elements[x, y] = this;
        }

    // Ucitaj drugu teksturu
    public void loadTexture (int adjacentCount)
        {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
        }

	// Da li je jos pokrivena
	public bool isCovered() {
		return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
	}

	void OnMouseUpAsButton() {
		// Mina
		if (mine) {
			// Pokazi sve mine
			Grid.uncoverMines();

			// Igra gotova
			//print("Izgubili ste");
			GameObject.Find("GameLogic").GetComponent<Elements>().displayMenu();
		}
		// Nije mina
		else {
			// Broj mina 
			int x = (int)transform.position.x;
			int y = (int)transform.position.y;
			loadTexture(Grid.adjacentMines(x, y));

			// Pokazi sve gdje nema mina
			Grid.FFuncover(x, y, new bool[Grid.w, Grid.h]);

			// Provjeri da li je pobjeda
			if (Grid.isFinished())
				print("Cestitamo ! Pobijedili ste!");
		}
	}
}
