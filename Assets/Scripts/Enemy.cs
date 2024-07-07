using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[Serializable]
public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    public Level level;
    public float MaxHp;
    public float CurrentHp;
    public float MS;
    public int waveCost;
    public int PathIndex;
    void Start()
    {
        CurrentHp = MaxHp;
        PathIndex = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = level.Path[PathIndex].transform.position;
        Vector3 MoveDirection = (target - transform.position).normalized;
        Vector3 newPosition = transform.position + MoveDirection*MS*Time.deltaTime;
        rb.MovePosition(newPosition);
    }
    public void setlevel(Level level)
    {
        this.level = level;
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PathIndex == level.Path.Length - 1)
        {
            Die();
        }
        else
        {
            PathIndex++;
        }
    }
}
