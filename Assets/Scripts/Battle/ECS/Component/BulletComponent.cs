using UnityEngine;

namespace ECS
{
    [System.Serializable]
    public class BulletComponent:BaseComponent
    {
        public float lifeTime;
        public float speed = 0.5f;
        
        public Vector3 targetPosition;
        public static void AddComponent(Entity entity)
        {
            entity.bullet = new BulletComponent();
        }
    }
}