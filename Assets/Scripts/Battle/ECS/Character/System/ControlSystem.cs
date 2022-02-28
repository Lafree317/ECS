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
            foreach(Character entiy in ECSManager.Instance.allEntitis)
            {
                if(entiy.control == null) continue;

                if (Input.GetKey(KeyCode.W))
                {
                    entiy.move.moveY = 1;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    entiy.move.moveY = -1;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    entiy.move.moveX = -1;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    entiy.move.moveX = 1;
                }

                if(Input.GetKeyDown(KeyCode.Space))
                {
                    entiy.attack.isShooting = true;
                }
                else
                {
                    entiy.attack.isShooting = false;
                }

            }

        }
    }
}
