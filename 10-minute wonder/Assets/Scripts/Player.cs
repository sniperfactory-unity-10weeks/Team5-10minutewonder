using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerHP; //플레이어 최대 체력
    public float recoverHP; //플레이어 체력 회복량
    public float AttackDamage; //플레이어 공격력
    public float AttackSpeed; //초당 공격 속도
    //public float AttackRange = 0; // 공격 범위 (보류)
    public float PlayerSpeed; // 플레이어 이동 속도

    // 체력 관련
    private float currentHp;
    private float healTerm = 5;
    private float currentHealTime;

    public Vector3 newVelocity;
    private Rigidbody2D playerRB;
    public Vector3 Axis;

    SpriteRenderer sprite;
    Animator anim;
    public Scanner scanner;

    // Start is called before the first frame update
    void Awake()
    {
        /* 플레이어 프리펩쪽은 아직 손 못댔습니다.
        PlayerHP = PlayerPrefs.GetFloat("PlayerHP");
        recoverHP = PlayerPrefs.GetFloat("recoverHP");
        AttackDamage = PlayerPrefs.GetFloat("AttakDamage");
        AttackSpeed = PlayerPrefs.GetFloat("AttackSpeed");
        PlayerSpeed = PlayerPrefs.GetFloat("PlayerSpeed");
        */
        currentHp = PlayerHP;
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
            playerRB.velocity = Vector3.zero;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
