using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float PlayerHP = 100; //플레이어 최대 체력
    public float recoverHP = 0; //플레이어 체력 회복량
    public float AttackDamage = 10; //플레이어 공격력
    public float AttackSpeed = 2; //초당 공격 속도
    //public float AttackRange = 0; // 공격 범위 (보류)
    public float PlayerSpeed = 5; // 플레이어 이동 속도

}
