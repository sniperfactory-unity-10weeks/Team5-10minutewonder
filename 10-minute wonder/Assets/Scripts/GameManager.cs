using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    StatUpInLobby statUpInLobby;

    public Player player;
    public PoolManager pool;

    //�ʱ� ����
    public float initialHp = 100f;
    public float initialRecover = 0f;
    public float initialAttckPower = 10f;
    public float initialAttackCoolTime = 3f;
    public float initialMoveSpeed = 8f;

    //��ȭ ����
    public float hp = 100f;
    public float recover = 0f;
    public float attckPower = 10f;
    public float attackCoolTime = 3f;
    public float moveSpeed = 8f;

    public int gold = 1000; //��差

    //���� Ŭ������� ǥ��
    public float playTime; //�÷��� �ð�
    public int kill = 0; //óġ�� ���� ��
    public int goldScore = 0; //�÷��̿��� ȹ���� ��差


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
            Debug.Log("�ı�");
        }
    }

    private void Start()
    {
        initialHp = PlayerPrefs.GetFloat("InitialPlayerHP", initialHp);
        initialRecover = PlayerPrefs.GetFloat("InitialRecoverHP", initialRecover);
        initialAttckPower = PlayerPrefs.GetFloat("InitialAttackDamage", initialAttckPower);
        initialAttackCoolTime = PlayerPrefs.GetFloat("InitialAttackSpeed", initialAttackCoolTime);
        initialMoveSpeed = PlayerPrefs.GetFloat("InitialPlayerSpeed", initialMoveSpeed);

        // ��ȭ�� ���� �ε� (��ȭ���� �ʾҴٸ� �ʱ� �������� �ʱ�ȭ)
        hp = PlayerPrefs.GetFloat("PlayerHP", initialHp);
        recover = PlayerPrefs.GetFloat("RecoverHP", initialRecover);
        attckPower = PlayerPrefs.GetFloat("AttackDamage", initialAttckPower);
        attackCoolTime = PlayerPrefs.GetFloat("AttackSpeed", initialAttackCoolTime);
        moveSpeed = PlayerPrefs.GetFloat("PlayerSpeed", initialMoveSpeed);
    }

    // PlayerPrefs�� ����Ͽ� ������ ����
    public void SavePlayerStats()
    {
        PlayerPrefs.SetFloat("InitialPlayerHP", initialHp);
        PlayerPrefs.SetFloat("InitialRecoverHP", initialRecover);
        PlayerPrefs.SetFloat("InitialAttackDamage", initialAttckPower);
        PlayerPrefs.SetFloat("InitialAttackSpeed", initialAttackCoolTime);
        PlayerPrefs.SetFloat("InitialPlayerSpeed", initialMoveSpeed);

        // ��ȭ�� ���� ����
        PlayerPrefs.SetFloat("PlayerHP", hp);
        PlayerPrefs.SetFloat("RecoverHP", recover);
        PlayerPrefs.SetFloat("AttackDamage", attckPower);
        PlayerPrefs.SetFloat("AttackSpeed", attackCoolTime);
        PlayerPrefs.SetFloat("PlayerSpeed", moveSpeed);

        PlayerPrefs.Save();
    }

        private void Update()
    {
        // �������� ��� �ּ�ó�� �߽��ϴ�.
        //gold = statUpInLobby.NowGold();
    }

}

/* ��ȭ �޼���
 * 
 * �κ��� ��ũ��Ʈ�� �� ��ȭ�Ҷ����� �ż���鵵 ���� �۵��ǰ� ���ֽø� �˴ϴ�.
 * ���� ���ġ�� �ϴ� 10���� �����ؼ� �ۼ��س����ϴ�. ���� ���� �ٶ�
    public void EnhancePlayerHP() // �ִ�ü��
    {
        GameManager.instance.hp += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceRecoverHP() // ü�����
    {
        GameManager.instance.recover += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackDamage() // ���ݷ�
    {
        GameManager.instance.attckPower += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackSpeed() // ���ݼӵ�
    {
        GameManager.instance.attackCoolTime += 10f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhancePlayerSpeed() // �̵��ӵ�
    {
        GameManager.instance.moveSpeed += 10f;
        GameManager.instance.SavePlayerStats();
    }
 */
