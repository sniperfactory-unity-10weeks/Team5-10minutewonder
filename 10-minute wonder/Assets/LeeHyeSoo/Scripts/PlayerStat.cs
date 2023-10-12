using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    GameManager gameManager;
    

    public Text attckpowerText; //���ݷ� �ؽ�Ʈ
    public Text attackCoolTimeText; //������Ÿ�� �ؽ�Ʈ
    public Text hpText; //ü�� �ؽ�Ʈ
    public Text recoverText; //ȸ����(�����) �ؽ�Ʈ
    public Text moveSpeedText; //�̵��ӵ� �ؽ�Ʈ
    public Text goldText; //��差 �ؽ�Ʈ



    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find(name: "GameManager").GetComponent<GameManager>();
        


    }

    // Update is called once per frame
    void Update()
    {
        
        StatTextInLobby();
        
    }

    void StatTextInLobby()
    {
        attckpowerText.text = "���ݷ�: " + gameManager.attckPower.ToString();
        attackCoolTimeText.text = "���� ��Ÿ��: " + gameManager.attackCoolTime.ToString();
        hpText.text = "HP: " + gameManager.hp.ToString();
        recoverText.text = "ȸ����: " + gameManager.recover.ToString();
        moveSpeedText.text = "�̵��ӵ�: " + gameManager.moveSpeed.ToString();
        goldText.text = "��差: " + gameManager.gold.ToString() + " G";
    }
}
