using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObj : ScriptableObject
{
    [SerializeField ]
    private List<InventorySlot> containerL = new List<InventorySlot>();

    public List<InventorySlot> ContainerL { get => containerL; set => containerL = value; }

    public void AddItem(ItemData _itemdata, int _amount)
    {
        bool hasItem = false;
        for (int i = 0; i < ContainerL.Count; i++)
        {
            if (ContainerL[i].ItemD == _itemdata)
            {
                ContainerL[i].AmountAdd(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            ContainerL.Add(new InventorySlot(_itemdata, _amount));
        }
    }
 
    public InventorySlot GetItem(string id,string name)
    {
        InventorySlot itemS=null;
        foreach(var item in containerL)
        {
            if(item.ItemD.ItemName== name && item.ItemD.Id == id)
            {
                itemS = item;
                break;
            }
            
        }
       return itemS;
    }
}

[System.Serializable]
public class InventorySlot
{
    [SerializeField]
    private ItemData itemD;
    [SerializeField]
    private int amount;

    public InventorySlot(ItemData _itemdata, int _amount)
    {
        itemD = _itemdata;
        amount = _amount;

    }

    public ItemData ItemD { get => itemD; set => itemD = value; }
    public int Amount { get => amount; set => amount = value; }

    public void AmountAdd(int value)
    {
        Amount += value;
    }

}
