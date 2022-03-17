using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ECSManager:MonoSingleton<ECSManager>
    {
        public Entity enemy;
        public List<Entity> enemyList = new List<Entity>(0);
        public List<Entity> allEntitis = new List<Entity>(0);
        public List<Entity> allBullets = new List<Entity>(0);
        private MoveSystem move;

        private AttackSystem attack;
        private BulletSystem bullet;
        private EntityCreate create;
        
        void Start()
        {
            move = new MoveSystem();
            attack = new AttackSystem();
            bullet = new BulletSystem();
        }

        void Update()
        {
            move.Update();
            attack.Update();
            bullet.Update();
        }

        public void CreatePlayer()
        {
            Entity player = EntityCreate.Instance.CreateCharacter();
            
            player.art.transform.localPosition = new Vector3(0,0,0);
            allEntitis.Add(player);
        }

        public void CreateBullet(Transform selfTran,Vector3 targetPosition)
        {
            Entity bullet = EntityCreate.Instance.CreateBullet(selfTran,targetPosition);
            allEntitis.Add(bullet);
        }
        
        public void DesrotyEntity(Entity entity)
        {
            ECSManager.Instance.allEntitis.Remove(entity);   
            Destroy(entity.art.go);
        }
    }

}