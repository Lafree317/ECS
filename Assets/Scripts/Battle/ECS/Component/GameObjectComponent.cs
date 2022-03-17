using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class GameObjectComponent:BaseMonoComponent 
    {
        public Entity entity;
        public GameObject go;
        public static void AddComponent(Entity entity)
        {
            entity.gameObjectComponent = entity.art.go.AddComponent<GameObjectComponent>();
            entity.gameObjectComponent.entity = entity;
            entity.gameObjectComponent.go = entity.art.go;
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Enemy" )
            {
                ECSManager.Instance.DesrotyEntity(entity);
                GameObjectComponent gameObjectComponent = other.gameObject.GetComponent<GameObjectComponent>();
            }
        }

        private void OnTriggerExit2D(Collider2D other) {

        }

        private void OnTriggerStay2D(Collider2D other) {
              
        }
    }
}