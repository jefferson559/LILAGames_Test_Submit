using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


[CreateAssetMenu]

public class TileData : ScriptableObject
{

    public TileBase[] tiles;

    public float tileNumber;

    public Text tileText;

    public List<TileValues> tileList;

}

public class TileValues
{
    public int tileNumber;

}
        
    


