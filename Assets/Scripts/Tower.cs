using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    int damage;
    int FireRate;
    int Range;
    float AttackTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackTimer += Time.deltaTime;
        if(AttackTimer> FireRate)
        {
            ProjectileController ProjectileToSpawn ;


        }
    }
}
