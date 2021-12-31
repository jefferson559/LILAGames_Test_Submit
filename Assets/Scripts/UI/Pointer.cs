using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Pointer : MonoBehaviour
{

    [SerializeField]

    private Tilemap boardMap;

    [SerializeField]

    private List<TileData> tileDatas;


    private Dictionary<TileBase, TileData> dataFromTiles;

    private void Awake()
    {
        dataFromTiles = new Dictionary<TileBase, TileData>();

        foreach ( var TileData in tileDatas)
        {
            foreach  (var tile  in TileData.tiles)
            {
                dataFromTiles.Add(tile, TileData);
            }
        }

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = boardMap.WorldToCell(mousePos);

            TileBase selectedTile = boardMap.GetTile(gridPosition);

            Debug.Log("tile" + selectedTile + gridPosition);

            //float tileNumberOn = dataFromTiles[selectedTile].tileNumber;

            //print("tile number is :" + tileNumberOn);
            
                
            
        }
    }
}

