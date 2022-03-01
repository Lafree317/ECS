using UnityEngine;

namespace ECS
{
    public class ColliderComponent:MonoBehaviour
    {
        public BaseEntity entity;
        public static void AddComponent(BaseEntity entity)
        {
            entity.collider = entity.art.go.AddComponent<ColliderComponent>();
            entity.collider.entity = entity;

        }
        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Enemy")
            {
                ECSManager.Instance.DesrotyEntity(entity);
                GameObjectComponent gameObjectComponent = other.gameObject.GetComponent<GameObjectComponent>();
                gameObjectComponent.entity.art.ChangeColor();
            }
        }

        private void OnTriggerExit2D(Collider2D other) {

        }

        private void OnTriggerStay2D(Collider2D other) {
              
        }
    }
}