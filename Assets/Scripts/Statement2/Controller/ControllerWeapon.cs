using model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private InventoryObj playerInventory;
    [SerializeField]
    private InventoryObj equipInventory;
    private void Awake()
    {
        
    }
    void Start()
    {
        getWeapons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void getWeapons()
    {
        List<Weapon> listweapon = new List<Weapon>();
         
        for (int i = 0; i < playerInventory.ContainerL.Count; i++)
        {
            Debug.Log(playerInventory.ContainerL[i].ItemD);   

        }
    } 
    public void addWeaponToEquipInventory()
    {

    }

}
