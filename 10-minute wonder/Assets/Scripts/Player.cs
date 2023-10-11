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

    private Rigidbody2D playerRB;
    private float hAxis;
    private float vAxis;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = PlayerPrefs.GetFloat("PlayerHP");
        recoverHP = PlayerPrefs.GetFloat("recoverHP");
        AttackDamage = PlayerPrefs.GetFloat("AttakDamage");
        AttackSpeed = PlayerPrefs.GetFloat("AttackSpeed");
        PlayerSpeed = PlayerPrefs.GetFloat("PlayerSpeed");

        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
