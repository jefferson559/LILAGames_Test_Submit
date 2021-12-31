using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ammo Object", menuName = "Inventory System/Items/AmmoData")]
public class AmmoData: ItemData
{
    [SerializeField]
    private string mark;

    [SerializeField]
    private string projectiletype;

    [SerializeField]
    private string ogivetype;
    [SerializeField]
    private int moventspeed;

    public string Mark { get => mark; set => mark = value; }
    public string Projectiletype { get => projectiletype; set => projectiletype = value; }
    public string Ogivetype { get => ogivetype; set => ogivetype = value; }
    public int Moventspeed { get => moventspeed; set => moventspeed = value; }
}
