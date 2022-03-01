using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class AttackComponent:BaseComponent 
    {
        public bool isShooting = false;
        public bool isCopy = false;
        
        public static void AddComponent(BaseEntity entity)
        {
            entity.attack = new AttackComponent();
            
        }

        
        
    }
}

