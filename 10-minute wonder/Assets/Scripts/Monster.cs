using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;


public class Monster : MonoBehaviour
{

/* MonsterType
1. 추적만 하는 유닛 (일반) : 체력 = 페이즈 x 2 / 공격력 = 10
2. 추적 + 근접 (탱커)  : 체력 = 페이즈 x 4 / 공격력 = 10
3. 추적 + 원거리 (딜러) : 체력 = 페이즈 x 1 / 공격력 = 20
 */

    [Tooltip("Monster의 타입 번호 / 1 : 일반, 2 : 탱커, 3 : 원거리")]
    [Range(1, 3)]
    public int MonsterTyoe;

    public Rigidbody2D target;

    private float MonsterHP; //몬스터 체력
    private float MonsterAD = 10; //몬스터 공격력

    public float speed;

    private MonsterSpawn monsterSpawn;

    SpriteRenderer spriter;
    Rigidbody2D rigid;

    private bool isLive = true;

    private void Awake()
    {
        spriter = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

        switch (MonsterTyoe)
        {
            case 1:
                MonsterHP = monsterSpawn.Phase * 20;
                break;

            case 2:
                MonsterHP = monsterSpawn.Phase * 40;
                break;

            case 3:
                MonsterHP = monsterSpawn.Phase * 10;
                MonsterAD = 20;
                break;

        }
    }

    private void FixedUpdate()
    {
        if (!isLive) return;

        //진행 방향
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
        //target = GameManager.instance.player.GetComponent<Rigidbody2D>();
    }
}
