using model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Pistol")]
public class PistolData : WeaponData
{
    public enum PistolType
    {
        Normal,
        Revolver
    }

    // Start is called before the first frame update
    [SerializeField]
    private PistolType pistolType;

    public PistolType PistolType1 { get => pistolType; set => pistolType = value; }
    public override void setWeapon()
    {      
        this.Weapon1=  new Pistol(Id, pistolType, ItemName, FireRate, MagazineSize, Maxammo, ammos);
    }
}
