using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // �Ѿ� �ӵ�
    private Rigidbody2D bulletRigidbody; // �Ѿ� ������ �ٵ�

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = Player.dir * speed; // �Ѿ��� ���⺤�͸� �޾ƿ��� �ű⿡ �ӵ��� ������

        Destroy(gameObject, 3f); // �̰Ŵ� ������Ʈ Ǯ������ �ٽ� �ۼ��Ϸ��� ��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
