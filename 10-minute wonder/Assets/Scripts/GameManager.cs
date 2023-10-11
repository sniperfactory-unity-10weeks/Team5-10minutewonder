using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    //�ӽý���
    public float attckPower = 100; //���ݷ�
    public float attackCoolTime = 1; //������Ÿ��
    public float hp = 100; //ü��
    public float recover = 10; //ȸ����(�����)
    public float moveSpeed = 20; //�̵��ӵ�
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
        }
    }
}
