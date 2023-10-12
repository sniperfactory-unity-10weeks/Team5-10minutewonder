using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int id;
    public int prefabId;
    public float damage;
    public int count;
    private float speed;
    private float atkSpeed;

    Player player;

    private float timeAfterSpawn;


    private void Awake()
    {
        atkSpeed = (1 / GameManager.instance.player.AttackSpeed);
        player = GetComponentInParent<Player>();
    }

    private void FixedUpdate()
    {
        switch (prefabId)
        {
            case 0:
                timeAfterSpawn += Time.deltaTime;

                if (timeAfterSpawn > atkSpeed)
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