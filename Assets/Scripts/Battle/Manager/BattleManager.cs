using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECS;
public class BattleManager : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        ECSManager.Instance.CreatePlayer();
        ECSManager.Instance.CreateEnemy();
        ECSManager.Instance.CreateSpec();
    }

    public void CreateEntitis()
    {
        
    }
    
    private void Update() 
    {
        
    }
    
}
