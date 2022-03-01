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

        
        public static BaseEntity CreateBullet(Transform selfTran,Transform target)
        {
            BaseEntity bullet = new BaseEntity();
            ArtComponent.AddComponent(bullet,"Prefab/Bullet");
            BulletComponent.AddComponent(bullet);
            ColliderComponent.AddComponent(bullet);
            MoveComponent.AddComponent(bullet);
            bullet.bullet.target = target;
            bullet.move.speedY = 3.0f;
            bullet.move.speedX = 6.0f;
            bullet.art.transform.position = selfTran.position;
            return bullet;
        }

        public static BaseEntity CreateCharacter(string path)
        {
            BaseEntity character = new BaseEntity();
            ArtComponent.AddComponent(character,path);
            MoveComponent.AddComponent(character);
            AttackComponent.AddComponent(character);
            GameObjectComponent.AddComponent(character);
            character.move.moveY = 2.0f;
            character.move.moveX = 3.0f;
            return character;
        }
    }
}

