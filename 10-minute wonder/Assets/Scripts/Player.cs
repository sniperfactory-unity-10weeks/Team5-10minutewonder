using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerHP; //�÷��̾� �ִ� ü��
    public float recoverHP; //�÷��̾� ü�� ȸ����
    public float AttackDamage; //�÷��̾� ���ݷ�
    public float AttackSpeed; //�ʴ� ���� �ӵ�
    //public float AttackRange = 0; // ���� ���� (����)
    public float PlayerSpeed; // �÷��̾� �̵� �ӵ�

    // ü�� ����
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
        /* �÷��̾� ���������� ���� �� ������ϴ�.
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
        // �÷��̾��� ü���� 0�� �Ǹ� ����
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
