using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DisplayValue : MonoBehaviour
{
    
    public TextMesh tileNumberTxt;

    
    public int tileNumber;


    public List<TileBase> tileDatas;

    



    // Start is called before the first frame update
    void Start()
    {
        
        tileNumberTxt = GetComponent<TextMesh>();

        DisplayTileData();


       

      


    }
    public void DisplayTileData()
    {
        tileNumberTxt.text = tileNumber.ToString();
        
    }
   
}
       
    

   
