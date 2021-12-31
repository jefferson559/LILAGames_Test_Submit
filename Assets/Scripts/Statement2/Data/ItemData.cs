using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    [SerializeField]
    private  string id;
    [SerializeField]
    private string itemName;

    [SerializeField]
    private Sprite itemIcon;
    [SerializeField]
    private GameObject itemPrefab;
    [SerializeField]
    [TextArea(15, 20)]
    private string description;


    public string Id { get => id; set => id = value; }
    public string ItemName { get => itemName; set => itemName = value; }
    public Sprite ItemIcon { get => itemIcon; set => itemIcon = value; }
    public GameObject ItemPrefab { get => itemPrefab; set => itemPrefab = value; }
    public string Descripcion { get => description; set => description = value; }
}
