using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ECSManager:MonoSingleton<ECSManager>
    {
        public BaseEntity enemy;
        public List<BaseEntity> enemyList = new List<BaseEntity>(0);
        public List<BaseEntity> allEntitis = new List<BaseEntity>(0);
        public List<BaseEntity> allBullets = new List<BaseEntity>(0);
        private MoveSystem move;
        private ControlSystem control;
        private AttackSystem attack;
        private BulletSystem bullet;
        
        void Start()
        {
            move = new MoveSystem();
            control = new ControlSystem();
            attack = new AttackSystem();
            bullet = new BulletSystem();
        }

        void Update()
        {
            move.Update();
            control.Update();
            attack.Update();
            bullet.Update();
        }

        public void CreatePlayer()
        {
            BaseEntity player = BaseEntity.CreateCharacter("Prefab/Player");
            ControlComponent.AddComponent(player);
            player.art.transform.localPosition = new Vector3(-3,0,0);
            allEntitis.Add(player);
        }

        public void CreateSpec()
        {
            BaseEntity entiy = BaseEntity.CreateCharacter("Prefab/Player");
            ControlComponent.AddComponent(entiy);
            entiy.art.transform.localPosition = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
            allEntitis.Add(entiy);
        }

        public void CreateEnemy()
        {
            enemy = BaseEntity.CreateCharacter("Prefab/Enemy");
            enemy.art.transform.localPosition = new Vector3(4,0,0);
            allEntitis.Add(enemy);
        }

        public void CreateBullet(Transform selfTran,Transform targetTran)
        {
            BaseEntity bullet = BaseEntity.CreateBullet(selfTran,targetTran);
            allEntitis.Add(bullet);
        }
        
        public void DesrotyEntity(BaseEntity entity)
        {
            ECSManager.Instance.allEntitis.Remove(entity);   
            Destroy(entity.art.go);
        }
    }

}