using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class AttackSystem:BaseSystem
    {
        public BaseEntity target
        {
            get
            {
                return ECSManager.Instance.enemy;
            }
        }

        public override void Update() 
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                BaseEntity entity = ECSManager.Instance.allEntitis[i];
                if(entity.attack == null) continue;
                if(entity.attack.isShooting)
                {
                    ECSManager.Instance.CreateBullet(entity.art.transform,target.art.transform);
                    entity.attack.isShooting = false;
                }
                else if(entity.attack.isCopy)
                {
                    ECSManager.Instance.CreateSpec();
                    entity.attack.isCopy = false;
                }
                
            }
        }
    }
}
