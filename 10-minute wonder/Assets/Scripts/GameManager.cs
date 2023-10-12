using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    StatUpInLobby statUpInLobby;

    public Player player;
    public PoolManager pool;

    //초기 스텟
    public float initialHp = 100f;
    public float initialRecover = 0f;
    public float initialAttckPower = 10f;
    public float initialAttackCoolTime = 3f;
    public float initialMoveSpeed = 8f;

    //강화 스텟
    public float hp = 100f;
    public float recover = 0f;
    public float attckPower = 10f;
    public float attackCoolTime = 3f;
    public float moveSpeed = 8f;

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
            Debug.Log("파괴");
        }
    }

    private void Start()
    {
        initialHp = PlayerPrefs.GetFloat("InitialPlayerHP", initialHp);
        initialRecover = PlayerPrefs.GetFloat("InitialRecoverHP", initialRecover);
        initialAttckPower = PlayerPrefs.GetFloat("InitialAttackDamage", initialAttckPower);
        initialAttackCoolTime = PlayerPrefs.GetFloat("InitialAttackSpeed", initialAttackCoolTime);
        initialMoveSpeed = PlayerPrefs.GetFloat("InitialPlayerSpeed", initialMoveSpeed);

        // 강화된 스텟 로드 (강화되지 않았다면 초기 스텟으로 초기화)
        hp = PlayerPrefs.GetFloat("PlayerHP", initialHp);
        recover = PlayerPrefs.GetFloat("RecoverHP", initialRecover);
        attckPower = PlayerPrefs.GetFloat("AttackDamage", initialAttckPower);
        attackCoolTime = PlayerPrefs.GetFloat("AttackSpeed", initialAttackCoolTime);
        moveSpeed = PlayerPrefs.GetFloat("PlayerSpeed", initialMoveSpeed);
    }

    // PlayerPrefs를 사용하여 스텟을 저장
    public void SavePlayerStats()
    {
        PlayerPrefs.SetFloat("InitialPlayerHP", initialHp);
        PlayerPrefs.SetFloat("InitialRecoverHP", initialRecover);
        PlayerPrefs.SetFloat("InitialAttackDamage", initialAttckPower);
        PlayerPrefs.SetFloat("InitialAttackSpeed", initialAttackCoolTime);
        PlayerPrefs.SetFloat("InitialPlayerSpeed", initialMoveSpeed);

        // 강화된 스텟 저장
        PlayerPrefs.SetFloat("PlayerHP", hp);
        PlayerPrefs.SetFloat("RecoverHP", recover);
        PlayerPrefs.SetFloat("AttackDamage", attckPower);
        PlayerPrefs.SetFloat("AttackSpeed", attackCoolTime);
        PlayerPrefs.SetFloat("PlayerSpeed", moveSpeed);

        PlayerPrefs.Save();
    }

        private void Update()
    {
        // 오류나서 잠시 주석처리 했습니다.
        //gold = statUpInLobby.NowGold();
    }

}

/* 강화 메서드
 * 
 * 로비쪽 스크립트에 이 강화할때마다 매서드들도 같이 작동되게 해주시면 됩니다.
 * 스텟 상승치는 일단 10으로 통일해서 작성해놨습니다. 추후 수정 바람
    public void EnhancePlayerHP() // 최대체력
    {
        GameManager.instance.hp += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceRecoverHP() // 체력재생
    {
        GameManager.instance.recover += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackDamage() // 공격력
    {
        GameManager.instance.attckPower += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackSpeed() // 공격속도
    {
        GameManager.instance.attackCoolTime += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhancePlayerSpeed() // 이동속도
    {
        GameManager.instance.moveSpeed += 10f;
        GameManager.instance.SavePlayerStats();
    }
 */
