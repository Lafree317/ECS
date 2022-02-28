using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class AttackSystem:BaseSystem
    {
        public Character target
        {
            get
            {
                return ECSManager.Instance.enemy;
            }
        }

        public override void Update() 
        {
            foreach(Character entity in ECSManager.Instance.allEntitis)
            {
                if(entity.attack.isShooting == false) continue;
                
                ECSManager.Instance.CreateBullet(entity.art.transform,target.art.transform);

            }
        }
    }
}
