using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    /*count down 30 sec
         * Start first wave
         * spawn enemy's on Start point
         * wait x time spawn next enemy
         * wait until all enemys are dead
         * (either killed by defences or made it to tower)
         * wait till start button is pressed
         * set level to next level
         * repeat above until stage is over
        */
    [SerializeField]
    public Level CurrentLevel;
    public float TimePerEnemy = 5;
    public float SpawnTimer = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnTimer > TimePerEnemy && CurrentLevel.CurrentWave.TotalWaveCost>0)
        {
            SpawnEnemy();
            SpawnTimer = 0;
        }
    }
    void SpawnEnemy()
    {
        Enemy EnemyToSpawn = CurrentLevel.CurrentWave.GetnextEnemy();
       Enemy EnemyInstance = Instantiate(EnemyToSpawn);
        EnemyInstance.transform.position = CurrentLevel.Path[0].transform.position + new Vector3(0, .6f, 0);
        EnemyInstance.setlevel(CurrentLevel);
    }
}
