using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerItems : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryObj inventoryObj;
    void Start()
    {
         
    }
    public void OnTriggerEnter(Collider other)
    {
        var item=other.GetComponent<Item>();
        if (item != null)
        {
            inventoryObj.AddItem(item._itemdata, 1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
