using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace model
{
    public class Rifle:Weapon
    {
        public Rifle(string _id,float maxRange, float minRange, string name, double fireRate, double magazineSize, int maxAmmo, string _typeArmo, List<Ammo> _ammo) : base(_id,name, fireRate, magazineSize,  maxAmmo,_ammo)
        {
            MinShotRange = minRange;
            MaxShotRange = maxRange;
        }

        public float MinShotRange{ get; set; }
        public  float MaxShotRange { get; set; }

        

        
    }
}
