using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //게임 매니저에 저장되어있는 스텟치 받아오기
    public float PlayerHP;
    public float recoverHP;
    public float AttackDamage;
    public float AttackSpeed;
    public float PlayerSpeed;

    // 획득한 골드
    public int getGold = 0;

    // 체력 관련
    public float currentHp;
    private float healTerm = 5;
    private float currentHealTime;

    // 사망처리
    public bool deadFlag;

    // 이동관련
    public Vector3 newVelocity;
    private Rigidbody2D playerRB;
    public Vector3 Axis;
    SpriteRenderer sprite;
    Animator anim;

    // 몬스터 추적
    public Scanner scanner;

    // Start is called before the first frame update
    void Awake()
    {
        PlayerHP = GameManager.instance.hp;
        recoverHP = GameManager.instance.recover;
        AttackDamage = GameManager.instance.attckPower;
        AttackSpeed = GameManager.instance.attackCoolTime;
        PlayerSpeed = GameManager.instance.moveSpeed;

        currentHp = PlayerHP;
        deadFlag = false;

        playerRB = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        scanner = GetComponent<Scanner>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Axis.x = Input.GetAxis("Horizontal");
        Axis.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // 플레이어의 체력이 0이 되면 정지
        if (currentHp <= 0)
        {
            deadFlag = true;
            playerRB.velocity = Vector3.zero;
            GameManager.instance.gold += getGold;
            return;
        }

        currentHealTime = Time.deltaTime;

        if (currentHealTime >= healTerm)
        {
            currentHealTime = 0;
            if (currentHp <= PlayerHP)
            {
                currentHp += recoverHP;
                Debug.Log(currentHp);
            }
        }

        float hSpeed = Axis.x * PlayerSpeed;
        float vSpeed = Axis.y * PlayerSpeed;

        newVelocity = new Vector3(hSpeed, vSpeed, 0);

        playerRB.velocity = newVelocity;
    }

    void LateUpdate()
    {
        anim.SetFloat("Speed", Axis.magnitude);
        if (Axis.x != 0)
        {
            sprite.flipX = Axis.x < 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!deadFlag)
        {
            Drops drops = other.GetComponent<Drops>();

            if (drops != null)
            {
                drops.Use(gameObject);
            }
        }
    }
}
