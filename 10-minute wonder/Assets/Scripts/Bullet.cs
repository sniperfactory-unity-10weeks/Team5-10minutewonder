using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // �Ѿ� �ӵ�
    private Rigidbody2D bulletRigidbody; // �Ѿ� ������ �ٵ�
    public float lifeTime = 1f;
    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = Weapon.dir * speed; // �Ѿ��� ���⺤�͸� �޾ƿ��� �ű⿡ �ӵ��� ������
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
