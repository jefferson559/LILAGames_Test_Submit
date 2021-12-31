using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace model{
    public class Weapon
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double FireRate { get; set; }

        public double MagazineSize { get; set; }

        public int MaxAmmo { get; set; }
        public int AmmoCount { get; set; }
        public bool _isEquip { get; set; }
        public List<Ammo> AmmoList{ get; set; }
     //   public string TypeArmo{ get; set; }
        /// <summary>
        /// order 1 primary
        /// order 2 secundary
        /// order 0 default
        /// </summary>
        public int Order { get; set; }
        public  Weapon(string _id,string name, double fireRate, double magazineSize, int maxAmmo ,  List<Ammo> ammo)
        {
            Id = _id;
            Name = name;
            FireRate = fireRate;
            MagazineSize = magazineSize;
            MaxAmmo = maxAmmo;
            AmmoCount = maxAmmo;
            //TypeArmo = _typeArmo;
        }

        public virtual void shoot( GameObject projectile, Vector3 position, Quaternion rotation) { 
            foreach(var ammo in AmmoList)
            {
                if (ammo._isEquip)
                {
                    Object.Instantiate(projectile, position, rotation);
                }
            }
        }      

    }
}

