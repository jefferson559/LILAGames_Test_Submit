using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilePointer : MonoBehaviour
{

    public TileBase tile;

    public Tilemap board;

    public Vector3Int location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click!");
            GetT();
            

        }
        
    }

    public void GetT()
    {
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        location = board.WorldToCell(mp);

        if (board.GetTile(location))
        {
            Debug.Log("Tile found");
        }
        else
        {
            Debug.Log("Tile not found");
        }
    }

    
}


