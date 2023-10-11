using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    //임시스텟
    public float attckPower = 100; //공격력
    public float attackCoolTime = 1; //공격쿨타임
    public float hp = 100; //체력
    public float recover = 10; //회복력(재생력)
    public float moveSpeed = 20; //이동속도
    public int gold = 1000; //골드량

    //게임 클리어오버 표시
    public float playTime; //플레이 시간
    public int kill = 0; //처치한 몬스터 수
    public int goldScore = 0; //플레이에서 획득한 골드량
    

    //Sinleton Pattern
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
