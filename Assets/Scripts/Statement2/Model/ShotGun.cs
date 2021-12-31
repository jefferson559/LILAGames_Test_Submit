using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace model
{
    public class ShotGun : Weapon
    {
        private int numberBarrel { get; set; }
        private string  barrelType { get; set; }  
        public ShotGun(string _id, string name, double fireRate, double magazineSize, int maxAmmo , List<Ammo> _ammo) : base(_id,name, fireRate, magazineSize, maxAmmo , _ammo)
        {           
        }
      
    }
}