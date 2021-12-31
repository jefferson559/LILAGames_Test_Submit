using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/ShotGun")]
public class ShotGunData : WeaponData
{
    [SerializeField]
    private int numberBarrel;

    [SerializeField]
    private string barrelType;

    public int NumberBarrel { get => numberBarrel; set => numberBarrel = value; }
    public string BarrelType { get => barrelType; set => barrelType = value; }
}
