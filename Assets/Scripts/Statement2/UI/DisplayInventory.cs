using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private InventoryObj gameInventory;
    //[SerializeField]
    //private InventoryObj equipInventory;
    [SerializeField]
    private int x_start;
    [SerializeField]
    private int y_start;
    [SerializeField]
    private int x_space_betitems;
    [SerializeField]
    private int y_space_betitems;
    [SerializeField]
    private int number_of_colum;

    private Dictionary<InventorySlot, GameObject> equipedUIDicInventory;

    private Dictionary<InventorySlot, ItemData> equipInventory;

    private Dictionary<InventorySlot, GameObject> gameUiDicInventory;
    void Start()
    {
        CreateDisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        updateDisplay();
    }
    public void updateDisplay() {
        for (int i = 0; i <= gameInventory.ContainerL.Count; i++)
        {
            var obj = Instantiate(gameInventory.ContainerL[i].ItemD.ItemPrefab, Vector3.zero, Quaternion.identity, transform);

            if (gameUiDicInventory.ContainsKey(gameInventory.ContainerL[i])){
                gameUiDicInventory[gameInventory.ContainerL[i]].GetComponentInChildren<TextMeshProUGUI>().text = gameInventory.ContainerL[i].Amount.ToString();
            }
               
            else {
                
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);

                obj.GetComponentInChildren<TextMeshProUGUI>().text = gameInventory.ContainerL[i].Amount.ToString();
                gameUiDicInventory.Add(gameInventory.ContainerL[i], obj);
            }
            if (!equipedUIDicInventory.ContainsKey(gameInventory.ContainerL[i])){
                if ((gameInventory.ContainerL[i].ItemD is WeaponData) && ((WeaponData)gameInventory.ContainerL[i].ItemD).IsEquiped)
                {
                    equipedUIDicInventory.Add(gameInventory.ContainerL[i], obj);
                    equipInventory.Add(gameInventory.ContainerL[i], gameInventory.ContainerL[i].ItemD);
                }
            }

        }
    }
    public void CreateDisplayInventory()
    {       
        for(int i = 0;i<= gameInventory.ContainerL.Count;i++)
        {
            var obj=Instantiate(gameInventory.ContainerL[i].ItemD.ItemPrefab,Vector3.zero,Quaternion.identity,transform);
            
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            
            obj.GetComponentInChildren<TextMeshProUGUI>().text=gameInventory.ContainerL[i].Amount.ToString();

            gameUiDicInventory.Add(gameInventory.ContainerL[i], obj);
             
            if((gameInventory.ContainerL[i].ItemD is WeaponData)&& ((WeaponData)gameInventory.ContainerL[i].ItemD).IsEquiped)
            {
                equipedUIDicInventory.Add(gameInventory.ContainerL[i], obj);
                equipInventory.Add(gameInventory.ContainerL[i], gameInventory.ContainerL[i].ItemD);
            }
        }
    }
     

    public Vector3 GetPosition(int i)
    {
        return new Vector3(x_start+(x_space_betitems * (i % number_of_colum)), y_start+(-y_space_betitems * (i / number_of_colum)), 0f);
    }
}
