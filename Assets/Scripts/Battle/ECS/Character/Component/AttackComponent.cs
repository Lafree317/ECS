using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class AttackComponent:BaseComponent 
    {
        public bool isShooting = false;
        
        public static void AddComponent(Character entity)
        {
            entity.attack = new AttackComponent();
            
        }

        
        
    }
}

