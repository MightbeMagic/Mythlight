using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
	[SerializeField] string buildingName = "";
	[SerializeField] int buildingWidth;
    [SerializeField] int buildingHeight;
	[SerializeField] GameObject tilePrefab = null;
	List<GridPiece> tiles = null;

	private void Awake()
	{
		tiles = new List<GridPiece>();

		InitializeTiles();
	}


	void InitializeTiles()
	{
		bool setcolor = true;
		if(tilePrefab)
		{
			for (int row = -(buildingWidth / 2); row < buildingWidth / 2; row++)
			{
				for (int col = 0; col < buildingHeight; col++)
				{
					if (!(buildingWidth % 2 == 0 && col == buildingHeight - 1))setcolor = !setcolor;
					var newTile = Instantiate(tilePrefab, (Vector3.zero + new Vector3(row, col, 0)), Quaternion.identity, this.transform);
					newTile.GetComponent<GridPiece>().SetColor(setcolor ? Color.black : Color.white);
					tiles.Add(newTile.GetComponent<GridPiece>());
				}
			}
		}
	}

	void LoadBuilding()
	{
		
	}
}
