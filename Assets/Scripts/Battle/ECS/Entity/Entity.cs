using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class Entity
    {
        public MoveComponent move;
        public AttackComponent attack;
        public ArtComponent art;
        public ControlComponent control;
        public BulletComponent bullet;
        public GameObjectComponent gameObjectComponent;

        
        public static Entity CreateBullet(Transform selfTran,Vector3 targetPosition)
        {
            Entity entity = new Entity();
            ArtComponent.AddComponent(entity,"Prefab/Bullet");
            BulletComponent.AddComponent(entity);
            MoveComponent.AddComponent(entity);
            
            entity.art.transform.position = selfTran.position;
            entity.bullet.targetPosition = targetPosition;
            entity.move.speedY = 3.0f;
            entity.move.speedX = 6.0f;
            
            return entity;
        }

        public static Entity CreateCharacter(string path)
        {
            Entity entity = new Entity();
            ArtComponent.AddComponent(entity,path);
            MoveComponent.AddComponent(entity);
            AttackComponent.AddComponent(entity);
            GameObjectComponent.AddComponent(entity);
            entity.move.speedY = 2.0f;
            entity.move.speedX = 3.5f;
            return entity;
        }
    }
}

