using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid   {

	// Postavljanje matrice
	public static int w = 10; // sirina
	public static int h = 11; // visina
	public static Elements[,] elements = new Elements[w, h];

	// Otkriva sve mine
	public static void uncoverMines() {
		foreach (Elements elem in elements)
			if (elem.mine)
				elem.loadTexture(0);
	}

	// Provjerava da li je mina na tim koordinatama matrice
	public static bool mineAt(int x, int y) {
		// Provjera da li su u opsegu koordinate
		if (x >= 0 && y >= 0 && x < w && y < h)
			return elements[x, y].mine;
		return false;
	}

	// Broji kolicinu mina za element
	public static int adjacentMines(int x, int y) {
		int count = 0;

		if (mineAt(x,   y+1)) ++count; // vrh
		if (mineAt(x+1, y+1)) ++count; // gore-desno
		if (mineAt(x+1, y  )) ++count; // desno
		if (mineAt(x+1, y-1)) ++count; // dole-desno
		if (mineAt(x,   y-1)) ++count; // dole
		if (mineAt(x-1, y-1)) ++count; // dole-lijevo
		if (mineAt(x-1, y  )) ++count; // lijevo
		if (mineAt(x-1, y+1)) ++count; // gore-lijevo

		return count;
	}

	// Popuni sve sa praznim elementima
	public static void FFuncover(int x, int y, bool[,] visited) {
		// koordinate u opsegu
		if (x >= 0 && y >= 0 && x < w && y < h) {
			// vec posjeceno
			if (visited[x, y])
				return;

			// u blizini
			elements[x, y].loadTexture(adjacentMines(x, y));

			// blizu mine
			if (adjacentMines(x, y) > 0)
				return;

			// 
			visited[x, y] = true;

			// 
			FFuncover(x-1, y, visited);
			FFuncover(x+1, y, visited);
			FFuncover(x, y-1, visited);
			FFuncover(x, y+1, visited);
		}
	}

	public static bool isFinished() {
		// Pokusaj pronaci neotkriveni a da nije mina
		foreach (Elements elem in elements)
			if (elem.isCovered() && !elem.mine)
				return false;
		// Nema ih pobjeda
		return true;
	}

}
