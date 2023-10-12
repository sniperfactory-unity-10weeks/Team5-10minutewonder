using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 총알 속도
    private Rigidbody2D bulletRigidbody; // 총알 리지드 바디
    public float lifeTime = 1f;
    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = Weapon.dir * speed; // 총알의 방향벡터를 받아오고 거기에 속도를 곱해줌
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= lifeTime)
        {
            gameObject.SetActive(false);
        }
    }
}
