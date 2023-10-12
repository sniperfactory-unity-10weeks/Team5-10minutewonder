using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int id;
    public int prefabId;
    public float damage = 10;
    public int count;
    public float speed;

    Player player;

    private float timeAfterSpawn;


    void Awake()
    {
        player = GetComponentInParent<Player>();
    }

    void Start()
    {
        speed = (1 / player.AttackSpeed);
    }

    void FixedUpdate()
    {
        switch (prefabId)
        {
            case 3:
                timeAfterSpawn += Time.deltaTime;

                if (timeAfterSpawn > speed)
                {
                    timeAfterSpawn = 0f;
                    Fire();
                }
                break;
        }
    }

    void Fire()
    {
        if (!player.scanner.nearestTarget)
            return;

        Vector3 teagetPos = player.scanner.nearestTarget.position;
        Vector3 dir = teagetPos - transform.position;
        dir = dir.normalized;

        Transform bullet = GameManager.instance.pool.Get(prefabId).transform;
        bullet.position = transform.position;
        bullet.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        bullet.GetComponent<Bullet>().Init(damage, count, dir);

    }
}