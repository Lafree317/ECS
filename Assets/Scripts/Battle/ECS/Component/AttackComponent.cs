using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    [System.Serializable]
    public class AttackComponent:BaseComponent 
    {
        public bool isAttack = false;
        public Vector2 targetPosition;
        public static void AddComponent(Entity entity)
        {
            entity.attack = new AttackComponent();
        }

        
        
    }
}

