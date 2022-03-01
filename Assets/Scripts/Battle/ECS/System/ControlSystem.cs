using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ControlSystem:BaseSystem
    {
        // public Entity player;
        public ControlSystem()
        {
            // player = ECSManager.Instance.player;
        }

        public override void Update()
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                BaseEntity entity = ECSManager.Instance.allEntitis[i];
                if(entity.control == null) continue;

                if (Input.GetKey(KeyCode.W))
                {
                    entity.move.moveY = 1;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    entity.move.moveY = -1;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    entity.move.moveX = -1;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    entity.move.moveX = 1;
                }

                entity.attack.isShooting = Input.GetKeyDown(KeyCode.Space);
                entity.attack.isCopy = Input.GetKeyDown(KeyCode.LeftControl);

            }

        }
    }
}
