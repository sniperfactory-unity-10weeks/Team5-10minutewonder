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
    public int MonsterType;

    public Rigidbody2D target;

    public float MonsterHP; //몬스터 체력
    public  float MonsterAD = 10; //몬스터 공격력
    public float initialHP;

    public float speed;

    public Spawner spawn;

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


    }

    private void FixedUpdate()
    {
        if(MonsterHP < 0)
        {
            MonsterDie();
        }


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
        initialHP = MonsterHP;
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();

        switch (MonsterType)
        {
            case 1:
                MonsterHP = spawn.Phase * 20;
                Debug.Log(MonsterHP);
                break;

            case 2:
                MonsterHP = spawn.Phase * 40;
                break;

            case 3:
                MonsterHP = spawn.Phase * 10;
                MonsterAD = 20;
                break;

        }
    }

    public void MonsterDie()
    {
        //Destroy(this.gameObject);
        MonsterHP = initialHP;
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            MonsterHP -= GameManager.instance.player.AttackDamage;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameManager.instance.player.currentHp -= MonsterAD;
        }
    }
}
