using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECS;
public class BattleManager : MonoBehaviour
{
    void Start()
    {
        ECSManager.Instance.CreatePlayer();
        ECSManager.Instance.CreateEnemy();
        Application.targetFrameRate = 60;
    }

    public void CreateEntitis()
    {
        
    }
    
    private void Update() 
    {
        
    }
    
}
