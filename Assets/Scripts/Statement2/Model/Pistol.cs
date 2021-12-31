using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace model
{
    public class Pistol : Weapon
    {
 
        private PistolData.PistolType Pistoltype { get; set; }
        public Pistol(string _id, PistolData.PistolType pistoltype, string name, double fireRate, double magazineSize, int maxAmmo , List<Ammo> _ammo) : base(_id,name, fireRate, magazineSize, maxAmmo ,_ammo)
        {           
            Pistoltype = pistoltype;
        }      
    }
}