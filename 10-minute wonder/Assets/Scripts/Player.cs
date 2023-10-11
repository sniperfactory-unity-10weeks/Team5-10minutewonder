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
