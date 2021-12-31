using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    public int tileNumber = 0;
    public TMP_Text tileText;


    // Start is called before the first frame update
    void Start()
    {
        //tileText = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       
    public void TileValues(int _tileNumber)
    {
        tileNumber = _tileNumber;
        tileText.text = tileNumber.ToString();
    }
}
