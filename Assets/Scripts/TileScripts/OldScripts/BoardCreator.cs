using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public class BoardCreator : MonoBehaviour
{
    
    public TileBase[] tiles;
    public List<GameObject> UITiles;

    public Tilemap tileMap;

    public int selectedTile = 0;

    public Transform tileGridUI;

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
        int i = 0;







        //Debug.Log("button pressed");
        for (int x = 0; x < 100; x++)
        {
            for (int y = 0; y < 90; y++)
            {
                
                tileMap.SetTile(new Vector3Int(x, y, 0), tiles[i]);
            }
        }
    }
}
