using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class GameObjectComponent:MonoBehaviour 
    {
        public BaseEntity entity;
        public static void AddComponent(BaseEntity entity)
        {
            entity.gameObjectComponent = entity.art.go.AddComponent<GameObjectComponent>();
            entity.gameObjectComponent.entity = entity;
        }
    }
}