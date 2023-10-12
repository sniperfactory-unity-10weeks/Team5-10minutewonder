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

    public float MonsterHP; //���� ü��
    public  float MonsterAD = 10; //���� ���ݷ�
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
