using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class MoveSystem:BaseSystem
    {
        
        public override void Update()
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                BaseEntity entity = ECSManager.Instance.allEntitis[i];
                if(entity.move.moveX == 0 && entity.move.moveY == 0)continue;

                Vector2 movePosition =  new Vector2();
                movePosition.x = entity.art.transform.localPosition.x + (entity.move.moveX * entity.move.speedX * Time.deltaTime);
                movePosition.y = entity.art.transform.localPosition.y + (entity.move.moveY * entity.move.speedY * Time.deltaTime);
                entity.move.moveX = 0;
                entity.move.moveY = 0;
                entity.art.transform.localPosition = movePosition;
            }
        }
    }
}
