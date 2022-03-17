using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    [System.Serializable]
    public class Entity
    {
        public MoveComponent move;
        public AttackComponent attack;
        public ArtComponent art;
        public ControlComponent control;
        public BulletComponent bullet;
        public GameObjectComponent gameObjectComponent;

        

    }
}

