using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class BoardCreator1 : MonoBehaviour
{
    
    public TileBase tile;

    public Tilemap tileMap;

    private int boardSize = 9000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateTileBoard()
    {

        for (int i = 0; i <= boardSize; i++)
        {
            //Tile tileObject = tile.GetComponent<Tile>();
            //tileObject.TileValues(i);
            //tileList.Add(tileObject);
            //Instantiate(tile, boardTransform);
            tileMap.SetTile(new Vector3Int(i, 0, 0), tile);
            Debug.Log("tile created");



        }
        //Debug.Log("button pressed");
        //for (int x = 800; x < 1300; x++)
        //{
        //    for (int y = 800; y < 1300; y++)
        //    {
        //        Debug.Log("tile created");
        //        tileMap.SetTile(new Vector3Int(x, y, 0), tile);
        //    }
        //}
    }
}
