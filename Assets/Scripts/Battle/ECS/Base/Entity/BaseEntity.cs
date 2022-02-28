using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class BaseEntity
    {
        public MoveComponent move;
        public AttackComponent attack;
        public ArtComponent art;
        public ControlComponent control;
        public BulletComponent bullet;
        public ColliderComponent collider;
        public GameObjectComponent gameObjectComponent;
    }
}

