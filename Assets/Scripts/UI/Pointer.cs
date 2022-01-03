using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Pointer : MonoBehaviour
{

    public GameObject textValues;


    [SerializeField]

    private Tilemap boardMap;

    [SerializeField]

    
    public List<Vector3> tileWorldLocations;

    private List<TileBase> tileDatas;


    private Dictionary<TileBase, TileData> dataFromTiles;

    

    private void Start()
    {
        
    }

    private void Update()
    {

       
        if (Input.GetMouseButtonDown(0))
        {
           
           
            


            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = boardMap.WorldToCell(mousePos);

            TileBase selectedTile = boardMap.GetTile(gridPosition);

            Debug.Log("tile" + selectedTile + gridPosition );

            if (selectedTile != null)
            {


                //float tileNumberOn = dataFromTiles[selectedTile].tileNumber;

                Vector3 v = (Vector3)gridPosition;
                v.x += 0.5f;
                v.y += 0.5f;
                Instantiate(textValues, v, Quaternion.identity);

                GetBlockTiles();
            }

            else
            {
                print("There is no tile on that position");
            }
                
            
        }
    }

    public void GetTilesOnBoard()
    {
        tileWorldLocations = new List<Vector3>();

        foreach (var pos in boardMap.cellBounds.allPositionsWithin)
        {
            Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
            Vector3 place = boardMap.CellToWorld(localPlace);
            if (boardMap.HasTile(localPlace))
            {
                tileWorldLocations.Add(place);
            }
        }

        print(tileWorldLocations);
    }

    public void GetBlockTiles()
    {
        BoundsInt area = boardMap.cellBounds;


        
        TileBase[] tileArray = boardMap.GetTilesBlock(area);

        tileDatas = new List<TileBase>();
        

        for (int index = 0; index < tileArray.Length; index++)
        {

            tileDatas.Add(tileArray[index]);
            print(tileArray[index]);

        }


       
    }
}


