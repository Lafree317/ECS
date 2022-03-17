using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ECS
{
    [System.Serializable]
    public class ControlComponent:BaseComponent 
    {
        public static void AddComponent(Entity entity)
        {
            entity.control = new ControlComponent();
        }

        public bool isShooting;

    }
}

