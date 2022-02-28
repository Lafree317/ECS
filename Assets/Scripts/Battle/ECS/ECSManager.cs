using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS
{
    public class ECSManager:MonoSingleton<ECSManager>
    {
        public Character enemy;
        public List<Character> enemyList = new List<Character>(0);
        public List<Character> allEntitis = new List<Character>(0);
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
            Character player = CreateCharacter("Prefab/Player");
            ControlComponent.AddComponent(player);
            allEntitis.Add(player);
        }

        public void CreateSpec()
        {
            Character entiy = CreateCharacter("Prefab/Player");
            ControlComponent.AddComponent(entiy);
            entiy.art.transform.localPosition = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
            allEntitis.Add(entiy);
        }

        public void CreateEnemy()
        {
            enemy = CreateCharacter("Prefab/Enemy");
            enemy.art.transform.localPosition = new Vector3(3,0,0);
            allEntitis.Add(enemy);

        }

        public Character CreateCharacter(string path)
        {
            Character character = new Character();
            ArtComponent.AddComponent(character,path);
            MoveComponent.AddComponent(character);
            AttackComponent.AddComponent(character);
            GameObjectComponent.AddComponent(character);
            return character;
        }


        public void CreateBullet(Transform selfTran,Transform targetTran)
        {
            Bullet bullet = Bullet.CreateBullet(selfTran,targetTran);
            allBullets.Add(bullet);
        }
        
    }

}