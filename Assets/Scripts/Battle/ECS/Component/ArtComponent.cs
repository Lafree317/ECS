using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XYFramework;
namespace ECS
{
    public class ArtComponent:BaseComponent 
    {
        public string prefabPath;
        public Transform transform;
        public GameObject go;
        public SpriteRenderer sprite;
        public static void AddComponent(Entity entity,GameObject inGo)
        {
            entity.art = new ArtComponent();
            entity.art.go = inGo;
            entity.art.transform = entity.art.go.transform;
        }

    }
}

