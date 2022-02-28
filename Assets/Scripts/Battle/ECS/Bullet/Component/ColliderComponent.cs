using UnityEngine;

namespace ECS
{
    public class ColliderComponent:MonoBehaviour
    {
        public BaseEntity entity;
        public static void AddComponent(BaseEntity entity)
        {
            GameObject go = entity.art.go.transform.GetChild(0).gameObject;
            entity.collider = go.AddComponent<ColliderComponent>();
            entity.collider.entity = entity;

        }
        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Enemy")
            {
                ECSManager.Instance.allBullets.Remove(entity);   
                Destroy(entity.art.go);
                GameObject parentGo = other.transform.parent.gameObject;
                GameObjectComponent gameObjectComponent = parentGo.GetComponent<GameObjectComponent>();
                gameObjectComponent.entity.art.ChangeColor();
            }

        }

        private void OnTriggerExit2D(Collider2D other) {

        }

        private void OnTriggerStay2D(Collider2D other) {
              
        }
    }
}