   using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class Wave
{
    
    public int TotalWaveCost;
    [SerializeField]
    public Enemy[] Enemies;
    public int reward;

    public Enemy GetnextEnemy()
    {
       int RandomIndex = Random.Range(0, Enemies.Length);
       Enemy randomEnemy = Enemies[RandomIndex];
        TotalWaveCost -= randomEnemy.waveCost;
        return randomEnemy;
    }
}
