using UnityEngine;

namespace ECS
{
    public class BulletSystem:BaseSystem
    {
        public override void Update() 
        {
            foreach(Bullet bullet in ECSManager.Instance.allBullets)
            {
                Vector3 normal =  bullet.bullet.target.position - bullet.art.transform.position;
                bullet.art.transform.position = bullet.art.transform.position + (normal.normalized * bullet.bullet.speed * Time.timeScale);
            }
        }
    }
}