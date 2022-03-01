using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class MoveComponent:BaseComponent 
    {
        public float speedX;
        public float speedY;
        public float moveX = 0;
        public float moveY = 0;

        public static void AddComponent(BaseEntity entity)
        {
            MoveComponent move  = new MoveComponent();
            move.speedX = 1f;
            move.speedY = 0.5f;
            entity.move = move;
        }
    }
}

