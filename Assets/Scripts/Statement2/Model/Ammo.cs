using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace model
{
    public class Ammo  
    {       
        public  string Mark { get; set; }
        public string ProjectileType { get; set; }

        public  string OgiveType { get; set; }
        public int MoventSpeed { get; set; }
        

        public bool _isEquip { get; set; }
        public Ammo(string mark, string projectileType, string ogiveType ,int moventSpeed)
        { 
            Mark = mark;
            ProjectileType = projectileType;
            OgiveType = ogiveType;
             
            MoventSpeed = moventSpeed;
        }
        public void Move(Transform transform ) {
            transform.position += transform.forward * MoventSpeed * Time.deltaTime;
        }
    }
}

