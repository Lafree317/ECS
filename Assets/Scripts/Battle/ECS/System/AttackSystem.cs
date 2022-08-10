using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class AttackSystem:BaseSystem
    {
        public override void Update() 
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                Entity entity = ECSManager.Instance.allEntitis[i];
                if(entity.attack == null) continue;
                if(entity.attack.isAttack)
                {
                    ECSManager.Instance.CreateBullet(entity.art.transform,entity.attack.targetPosition);
                    
                    entity.attack.isAttack = false;

                    RayReflect.Instance.p1 = new Vector2(entity.art.transform.position.x,entity.art.transform.position.y);
                    RayReflect.Instance.p2 = entity.attack.targetPosition;
         
                }
            }
        }
    }
}
