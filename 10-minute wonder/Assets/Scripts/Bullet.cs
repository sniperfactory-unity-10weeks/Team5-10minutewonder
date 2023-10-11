using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 총알 속도
    private Rigidbody2D bulletRigidbody; // 총알 리지드 바디

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = Player.dir * speed; // 총알의 방향벡터를 받아오고 거기에 속도를 곱해줌

        Destroy(gameObject, 3f); // 이거는 오브젝트 풀링으로 다시 작성하려고 함
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
