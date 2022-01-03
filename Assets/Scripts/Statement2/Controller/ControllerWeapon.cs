using model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWeapon : MonoBehaviour
{
    // Start is called before the first frame update

    /* [SerializeField]
     private InventoryObj equipInventory;*/
    private InventoryObj gameInventory;
    private Dictionary<InventorySlot, ItemData> equipInventory;
     

    public void Configure(InventoryObj _gameInventory, Dictionary<InventorySlot, ItemData> _equipInventory)
    {
        gameInventory = _gameInventory;
        equipInventory= _equipInventory;
    }
    private void Awake()
    {
        
    }
    void Start()
    {
       // getWeapons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void equipWeapon(string weaponName,int order)
    {

        for (int i = 0; i <= gameInventory.ContainerL.Count; i++)
        {
            if (gameInventory.ContainerL[i].ItemD.name == weaponName )
            {
                if (!equipInventory.ContainsKey(gameInventory.ContainerL[i])) {
                    ((WeaponData)(gameInventory.ContainerL[i].ItemD)).IsEquiped = true;
                    ((WeaponData)(gameInventory.ContainerL[i].ItemD)).Order = order;
                    equipInventory.Add(gameInventory.ContainerL[i], gameInventory.ContainerL[i].ItemD);
                }
                
            }
        }
    }
    public void addWeaponToEquipInventory()
    {

    }

}
