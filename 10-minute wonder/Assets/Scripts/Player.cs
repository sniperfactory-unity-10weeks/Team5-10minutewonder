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

    private float currentHp;
    private float healTerm = 5;
    private float currentHealTime;

    public Vector3 newVelocity;
    private Rigidbody2D playerRB;
    private float hAxis;
    private float vAxis;

    // Start is called before the first frame update
    void Start()
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
    }

    // Update is called once per frame
    void Update()
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
            }
        }

        Move();
    }

    // 플레이어의 이동은 newVelocity 활용
    void Move()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        float hSpeed = hAxis * PlayerSpeed;
        float vSpeed = vAxis * PlayerSpeed;

        newVelocity = new Vector3(hSpeed, vSpeed, 0);

        playerRB.velocity = newVelocity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 몬스터 접촉 시
        if (other.tag == "Enemy")
        {
            PlayerHP -= 10f;
            Debug.Log("hit");
        }
        // 근접 공격 피격 시
        if (other.tag == "MeleeAtk")
        {
            PlayerHP -= 10f;
        }
        // 원거리 공격 피격 시
        if (other.tag == "RangedAtk")
        {
            PlayerHP -= 20f;
        }
    }
}
