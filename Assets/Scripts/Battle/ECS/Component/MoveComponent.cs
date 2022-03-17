using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    [System.Serializable]
    public class MoveComponent:BaseComponent 
    {
        public float speedX = 0;
        public float speedY = 0;
        public float moveX = 0;
        public float moveY = 0;

        public static void AddComponent(Entity entity)
        {
            MoveComponent move  = new MoveComponent();
            move.speedX = 1f;
            move.speedY = 0.5f;
            entity.move = move;
        }
    }
}

