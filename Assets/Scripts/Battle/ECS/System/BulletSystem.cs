using UnityEngine;

namespace ECS
{
    public class BulletSystem:BaseSystem
    {
        public override void Update() 
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                Entity entity = ECSManager.Instance.allEntitis[i];
                if(entity.bullet == null) continue;
                if(entity.move.moveX != 0 || entity.move.moveY != 0) continue;
                Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(Camera.main,entity.art.transform.position);
                Vector3 normal =  entity.bullet.targetPosition - screenPos;
                entity.move.moveX =  normal.normalized.x;
                entity.move.moveY =  normal.normalized.y;
            }
        }
    }
}