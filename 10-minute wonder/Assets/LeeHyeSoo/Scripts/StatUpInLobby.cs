using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUpInLobby : MonoBehaviour
{
    GameManager gameManager;
    Stat stat;
    public int playergold;
    public int playerstatLevel = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find(name: "GameManager").GetComponent<GameManager>();
        stat = GameObject.FindAnyObjectByType<Stat>();

        playergold = gameManager.gold;

    }

    public void StatUpPlayer()//��ȭ�ϱ� ��ư ������ ��
    {
        if (stat.stat[0].name == "HP")
        {
            playerstatLevel = stat.statLevel[0];
            StatUpButton();
        }
        else if (stat.stat[1].name == "recover")
        {
            playerstatLevel = stat.statLevel[1];
            StatUpButton();
        }
        else if (stat.stat[2].name == "attckPower")
        {
            playerstatLevel = stat.statLevel[2];
            StatUpButton();
        }
        else if (stat.stat[3].name == "attackCoolTime")
        {
            playerstatLevel = stat.statLevel[3];
            StatUpButton();
        }
        else if (stat.stat[4].name == "attackRange")
        {
            playerstatLevel = stat.statLevel[4];
            StatUpButton();
        }
        else if (stat.stat[5].name == "moveSpeed")
        {
            playerstatLevel = stat.statLevel[5];
            StatUpButton();
        }


    }

    void StatUpButton()
    {

        if (playergold >= 10 && playerstatLevel != 3)
        {
            playergold -= 10; //10��� �Ҹ�
            playerstatLevel++;
            Debug.Log(("��ȭ�Ǿ����ϴ�. ���� ��差") + playergold);
        }
        else if (playergold < 10) //��ȭ�� ������ ���
        {
            Debug.Log(("��ȭ����.��� ����"));
        }
        else if (playerstatLevel == 3) //��ȭ 3�ܰ���� �Ϸ�� ���
        {
            Debug.Log(("�ִ� ��ȭ"));
        }
    }

    public int NowGold()
    {
        return playergold;
    }

    public int NowStatLevel()
    {
        return playerstatLevel;
    }
}
