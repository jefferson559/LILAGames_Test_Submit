using model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*public enum WeaponType
{
    Default,
    Rifle,
    Sub_machine,
    Pistol,
    ShotGun,
    Bomb
}*/

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Default")]
public abstract class WeaponData : ItemData
{
    [SerializeField]
    private double fireRate;

    [SerializeField]
    private double magazineSize;

    [SerializeField]
    private int maxammo;

    [SerializeField]
    private float shotrange;
    
    [SerializeField]
    private bool isEquiped;

    [SerializeField]
    private int order;
    [SerializeField]
    protected List<AmmoData> listamo;
    protected List<Ammo> ammos;
    public Weapon Weapon1 { set; get; }

    public double FireRate { get => fireRate; set => fireRate = value; }
    public double MagazineSize { get => magazineSize; set => magazineSize = value; }
    public int Maxammo { get => maxammo; set => maxammo = value; }
    public float Shotrange { get => shotrange; set => shotrange = value; }
    public bool IsEquiped { get => isEquiped; set => isEquiped = value; }
    public int Order { get => order; set => order = value; }

    public  void  setAmmoWeapon()
    {
        ammos = new List<Ammo>();
        foreach(var item in listamo)
        {
            Ammo  ammo = new Ammo (item.Mark,item.Projectiletype,item.Ogivetype,item.Moventspeed);
            ammos.Add(ammo);
        }
    }
    public virtual void  setWeapon(){ }
    /*public WeaponType weaponT;*/

}
