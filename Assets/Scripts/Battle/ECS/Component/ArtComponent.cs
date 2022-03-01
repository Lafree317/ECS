using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ArtComponent:BaseComponent 
    {
        public string prefabPath;
        public Transform transform;
        public GameObject go;
        public SpriteRenderer sprite;
        public static void AddComponent(BaseEntity entity,string prefabPath)
        {
            entity.art = new ArtComponent();
            entity.art.prefabPath = prefabPath;
            entity.art.LoadPrefab();
            

        }

        public void LoadPrefab()
        {   
            go = GameObject.Instantiate(Resources.Load<GameObject>(prefabPath));
            transform = go.transform;
            sprite = go.transform.GetChild(0).GetComponent<SpriteRenderer>();
            
            
        }

        public void ChangeColor()
        {
            Color color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
            sprite.color = color;
        }
    }
}

