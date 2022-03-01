using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ControlComponent:BaseComponent 
    {
        public static void AddComponent(BaseEntity entity)
        {
            entity.control = new ControlComponent();
        }

        public bool isShooting;
        
    }
}

