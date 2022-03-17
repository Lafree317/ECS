using UnityEngine;
using XYFramework;

namespace ECS
{
    public class EntityCreate:MonoSingleton<EntityCreate>
    {
        const string Pool_Bullet_Key = "Bullet";
        const string Pool_Character_Key = "Character";

        public Transform bullet;
        public SpawnPool bulletPool;
        public Transform character;
        public SpawnPool characterPool;
        
        void Awake()
        {
            InitPool();
        }

        public Entity CreateBullet(Transform selfTran,Vector3 targetPosition)
        {
            Transform trans =  bulletPool.Spawn(bullet);
            bulletPool.Despawn(trans,3.0f);
            Entity entity = new Entity();
            ArtComponent.AddComponent(entity,trans.gameObject);
            BulletComponent.AddComponent(entity);
            MoveComponent.AddComponent(entity);
            
            entity.art.transform.position = selfTran.position;
            entity.bullet.targetPosition = targetPosition;
            entity.move.speedY = 3.0f;
            entity.move.speedX = 6.0f;
            
            return entity;
        }

        public Entity CreateCharacter()
        {
            Transform trans = characterPool.Spawn(character);
            Entity entity = new Entity();
            ArtComponent.AddComponent(entity,trans.gameObject);
            MoveComponent.AddComponent(entity);
            AttackComponent.AddComponent(entity);
            GameObjectComponent.AddComponent(entity);
            ControlComponent.AddComponent(entity);
            entity.move.speedY = 2.0f;
            entity.move.speedX = 3.5f;
            return entity;
        }

        public void InitPool()
        {
            InitBulletPool();
            InitCharacterPool();
        }

        void InitBulletPool()
        {
            bulletPool = PoolManager.Pools.Create(Pool_Bullet_Key);
            PrefabPool prefabPool = new PrefabPool(bullet);
            prefabPool.cullDespawned = true;
            prefabPool.preloadAmount = 100;
            bulletPool.CreatePrefabPool(prefabPool);
        }

        void InitCharacterPool()
        {
            characterPool = PoolManager.Pools.Create(Pool_Character_Key);
            PrefabPool prefabPool = new PrefabPool(character);
            prefabPool.cullDespawned = true;
            prefabPool.preloadAmount = 100;
            characterPool.CreatePrefabPool(prefabPool);
        }
    }
}

