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
        /* �÷��̾� ���������� ���� �� ������ϴ�.
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
            }
        }

        Move();
    }

    // �÷��̾��� �̵��� newVelocity Ȱ��
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
        // ���� ���� ��
        if (other.tag == "Enemy")
        {
            PlayerHP -= 10f;
            Debug.Log("hit");
        }
        // ���� ���� �ǰ� ��
        if (other.tag == "MeleeAtk")
        {
            PlayerHP -= 10f;
        }
        // ���Ÿ� ���� �ǰ� ��
        if (other.tag == "RangedAtk")
        {
            PlayerHP -= 20f;
        }
    }
}
