using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class MoveSystem:BaseSystem
    {
        
        public override void Update()
        {
            foreach(Character entity in ECSManager.Instance.allEntitis)
            {
                if(entity.move.moveX == 0 && entity.move.moveY == 0)continue;

                Vector2 movePosition =  new Vector2();
                movePosition.x = entity.art.transform.localPosition.x + (entity.move.moveX * entity.move.speedX * Time.timeScale);
                movePosition.y = entity.art.transform.localPosition.y + (entity.move.moveY * entity.move.speedY * Time.timeScale);
                entity.move.moveX = 0;
                entity.move.moveY = 0;
                entity.art.transform.localPosition = movePosition;
            }
        }
    }
}
