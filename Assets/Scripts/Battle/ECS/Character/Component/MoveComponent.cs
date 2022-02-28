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

        public static void AddComponent(Character entity)
        {
            MoveComponent move  = new MoveComponent();
            move.speedX = 0.1f;
            move.speedY = 0.05f;
            entity.move = move;
        }
    }
}

