using model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInventory : MonoBehaviour
{
    [SerializeField]
    private InventoryObj playerInventory;
    [SerializeField]
    private InventoryObj equipInventory;
    // Start is called before the first frame update
    private Dictionary<InventorySlot, GameObject> dicPlayerInventory = new Dictionary<InventorySlot, GameObject>();
    
    private Dictionary<InventorySlot, GameObject> dicEquipInventory = new Dictionary<InventorySlot, GameObject>();
    
   
    void Start()
    { 
      //  dicPlayerInventory.Add(gameInventory.ContainerL,)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addWeaponToEquip(Weapon weapon)
    {
        
    }
}
