using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] bulletPools;

    private void Start()
    {
        bulletPools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < bulletPools.Length; index++)
        {
            bulletPools[index] = new List<GameObject>();
        }
    }
}
