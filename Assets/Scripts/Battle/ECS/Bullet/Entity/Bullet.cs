using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class Bullet:BaseEntity
    {

        public static Bullet CreateBullet(Transform selfTran,Transform target)
        {
            Bullet bullet = new Bullet();
            ArtComponent.AddComponent(bullet,"Prefab/Bullet");
            BulletComponent.AddComponent(bullet);
            ColliderComponent.AddComponent(bullet);
            bullet.bullet.target = target;
            bullet.art.transform.position = selfTran.position;
            return bullet;
        }

    }
}

