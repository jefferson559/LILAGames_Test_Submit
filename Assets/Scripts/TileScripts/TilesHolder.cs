using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilesHolder : MonoBehaviour
{
    private TileBase _baseTile;
    private TileData tileData;

    private void Awake()
    {
        _baseTile = (TileBase)Resources.Load("base", typeof(TileBase));
    }

    public TileBase GetBaseTile()
    {
        
        return _baseTile;
    }
}