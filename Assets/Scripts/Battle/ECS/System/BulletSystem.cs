using UnityEngine;

namespace ECS
{
    public class BulletSystem:BaseSystem
    {
        public override void Update() 
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                BaseEntity entity = ECSManager.Instance.allEntitis[i];
                if(entity.bullet == null) continue;
                Vector3 normal =  entity.bullet.target.position - entity.art.transform.position;
                entity.move.moveX =  normal.normalized.x;
                entity.move.moveY =  normal.normalized.y;
            }
        }
    }
}