using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float per;

    public float speed = 8f; // �Ѿ� �ӵ�

    private Rigidbody2D bulletRigidbody; // �Ѿ� ������ �ٵ�
    
    void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Init(float damdge, int per, Vector3 dir)
    {
        this.damage = damdge;
        this.per = per;

        if (per > -1)
        {
            bulletRigidbody.velocity = dir * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy") || per == -1)
        { return; }

        per--;

        if (per == -1)
        {
            bulletRigidbody.velocity = Vector2.zero;
            gameObject.SetActive(false);
        }
    }
}