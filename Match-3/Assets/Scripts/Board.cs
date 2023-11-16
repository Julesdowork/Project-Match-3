using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;

    private BackgroundTile[,] _allTiles;

    void Start()
    {
        _allTiles = new BackgroundTile[width, height];
        Setup();
    }

    private void Setup()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j);
                GameObject tile = Instantiate(tilePrefab, tempPosition, Quaternion.identity, transform);
                tile.name = "Tile(" + i + "," + j + ")";
            }
        }
    }
}
