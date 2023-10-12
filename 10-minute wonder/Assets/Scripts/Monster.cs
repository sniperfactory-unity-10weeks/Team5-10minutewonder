using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;


public class Monster : MonoBehaviour
{

/* MonsterType
1. ������ �ϴ� ���� (�Ϲ�) : ü�� = ������ x 2 / ���ݷ� = 10
2. ���� + ���� (��Ŀ)  : ü�� = ������ x 4 / ���ݷ� = 10
3. ���� + ���Ÿ� (����) : ü�� = ������ x 1 / ���ݷ� = 20
 */

    [Tooltip("Monster�� Ÿ�� ��ȣ / 1 : �Ϲ�, 2 : ��Ŀ, 3 : ���Ÿ�")]
    [Range(1, 3)]
    public int MonsterType;

    public Rigidbody2D target;

    private float MonsterHP; //���� ü��
    private float MonsterAD = 10; //���� ���ݷ�

    public float speed;

    SpriteRenderer spriter;
    Rigidbody2D rigid;
    public Spawner spawner;

    private bool isLive = true;

    private void Awake()
    {
        spriter = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

        switch (MonsterType)
        {
            case 1:
                MonsterHP = spawner.Phase * 20;
                break;

            case 2:
                MonsterHP = spawner.Phase * 40;
                break;

            case 3:
                MonsterHP = spawner.Phase * 10;
                MonsterAD = 20;
                break;

        }
    }

    private void FixedUpdate()
    {
        if (!isLive) return;

        //���� ����
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;

        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;

    }

    private void LateUpdate()
    {
        if (!isLive) return;
        spriter.flipX = target.position.x < rigid.position.x;
    }

    private void OnEnable()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();
    }
}
