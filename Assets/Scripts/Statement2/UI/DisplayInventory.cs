using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private InventoryObj playerInventory;
    [SerializeField]
    private InventoryObj equipInventory;
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
    
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDisplay()
    {       
        for(int i = 0;i< playerInventory.ContainerL.Count;i++)
        {
            var obj=Instantiate(playerInventory.ContainerL[i].ItemD.ItemPrefab,Vector3.zero,Quaternion.identity,transform);
            
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            
            obj.GetComponentInChildren<TextMeshProUGUI>().text=playerInventory.ContainerL[i].Amount.ToString();
             
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(x_start+(x_space_betitems * (i % number_of_colum)), y_start+(-y_space_betitems * (i / number_of_colum)), 0f);
    }
}
