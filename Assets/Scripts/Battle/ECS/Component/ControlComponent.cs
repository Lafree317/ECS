using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ECS
{
    public class ControlComponent:BaseComponent 
    {
        public static void AddComponent(Entity entity)
        {
            Debug.Log("111111");
            entity.control = new ControlComponent();
        }

        public bool isShooting;

    }
}

