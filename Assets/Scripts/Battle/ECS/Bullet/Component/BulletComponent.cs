using UnityEngine;

namespace ECS
{
    public class BulletComponent:BaseComponent
    {
        public float lifeTime;
        public float speed = 0.5f;
        
        public Transform target;
        public static void AddComponent(BaseEntity entity)
        {
            entity.bullet = new BulletComponent();
            
        }
    }
}