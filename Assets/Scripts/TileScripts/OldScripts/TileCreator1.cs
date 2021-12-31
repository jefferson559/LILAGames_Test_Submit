using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TileCreator1 : MonoBehaviour
{
    public GameObject tilex64;
    public int boardSize = 9000;

    public Transform boardTransform;

    //public TMP_InputField inputBoardSize;

    public GameObject boardPanel;

    

    public List<Tile> tileList;





    private void Awake()
    {
        tileList = new List<Tile>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateBoard()

    {
        //int.TryParse(inputBoardSize.text, out int result);
        //boardSize = result;


        if (boardSize <= 0)
        {
            Debug.Log("Board size cant be 0");
        }
        else
        {                                    
            for (int i = 1; i <= boardSize; i++)
            {
                Tile tileObject = tilex64.GetComponent<Tile>();
                tileObject.TileValues(i);
                tileList.Add(tileObject);
                Instantiate(tilex64, boardTransform );

                
                
               
       
            }
            
            boardPanel.SetActive(false);
        }
    }
    
    
}
