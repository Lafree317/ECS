using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XYFramework;
public class XYPoolManagerExample : MonoBehaviour
{
    public Transform Enemy;
    // Start is called before the first frame update
    void Start()
    {
        PoolManager.Pools.Create("Enemy");
        PrefabPool prefabPool = new PrefabPool(Enemy);
        prefabPool.cullDespawned = true;
        prefabPool.cullDelay = 1;
        prefabPool.cullAbove = 0;
        PoolManager.Pools["Enemy"].CreatePrefabPool(prefabPool);

    }

    // Update is called once per frame
    void Update()
    {
        Transform tran =  PoolManager.Pools["Enemy"].Spawn("Enemy");
        PoolManager.Pools["Enemy"].Despawn(tran,2.0f);
    }
}
