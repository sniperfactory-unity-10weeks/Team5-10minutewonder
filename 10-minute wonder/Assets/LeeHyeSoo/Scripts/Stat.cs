using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    StatUpInLobby statUpInLobby;
    GameManager gameManager;

    public GameObject[] stat;
    public int[] statLevel = new int[6];

    public void EnhancePlayerHP() // 최대체력
    {
        GameManager.instance.hp += 50f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceRecoverHP() // 체력재생
    {
        GameManager.instance.recover += 5;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackDamage() // 공격력
    {
        GameManager.instance.attckPower += 5f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhanceAttackSpeed() // 공격속도
    {
        GameManager.instance.attackCoolTime += 1f;
        GameManager.instance.SavePlayerStats();
    }

    public void EnhancePlayerSpeed() // 이동속도
    {
        GameManager.instance.moveSpeed += 1f;
        GameManager.instance.SavePlayerStats();
    }

    private void Start()
    {
        statUpInLobby = FindAnyObjectByType<StatUpInLobby>();
        gameManager = FindAnyObjectByType<GameManager>();


        for (int i = 0; i < statLevel.Length; i++)
        {
            statLevel[i] = 0;
        }
    }

    private void Update()
    {
        if (statUpInLobby.isRef)
        {
            statUpInLobby.isRef = false;
            StatUp();
        }

    }

    void StatUp()
    {
        if (stat[0].gameObject.activeSelf == true) //HP
        {
            statLevel[0] = statUpInLobby.NowStatLevel();

            if (statLevel[0] == 1)
            {
                EnhancePlayerHP();

            }
            else if (statLevel[0] == 2)
            {
                EnhancePlayerHP();


            }
            else if (statLevel[0] == 3)
            {
                EnhancePlayerHP();
            }

        }
        else if (stat[1].gameObject.activeSelf == true) //recover
        {
            statLevel[1] = statUpInLobby.NowStatLevel();

            if (statLevel[1] == 1)
            {
               EnhanceRecoverHP();
            }
            else if (statLevel[1] == 2)
            {
                EnhanceRecoverHP();
            }
            else if (statLevel[1] == 3)
            {
                EnhanceRecoverHP();
            }

        }
        else if (stat[2].gameObject.activeSelf == true) //attackpower
        {
            statLevel[2] = statUpInLobby.NowStatLevel();

            if (statLevel[2] == 1)
            {
                EnhanceAttackDamage();
            }
            else if (statLevel[2] == 2)
            {
                EnhanceAttackDamage();
            }
            else if (statLevel[2] == 3)
            {
                EnhanceAttackDamage();
            }

        }
        else if (stat[3].gameObject.activeSelf == true) //attackCoolTime
        {
            statLevel[3] = statUpInLobby.NowStatLevel();
            if (statLevel[3] == 1)
            {
                EnhanceAttackSpeed();
            }
            else if (statLevel[3] == 2)
            {
                EnhanceAttackSpeed();
            }
            else if (statLevel[3] == 3)
            {
                EnhanceAttackSpeed();
            }

        }
        else if (stat[4].gameObject.activeSelf == true) //attackRange
        {
            statLevel[4] = statUpInLobby.NowStatLevel();
            //if (statLevel[4] == 1)
            //{
            //    gameManager.EnhanceAttackSpeed();
            //}
            //else if (statLevel[4] == 2)
            //{
            //    gameManager.EnhanceAttackSpeed();
            //}
            //else if (statLevel[4] == 3)
            //{
            //    gameManager.EnhanceAttackSpeed();
            //}

        }
        else if (stat[5].gameObject.activeSelf == true) //moveSpeed
        {
            statLevel[5] = statUpInLobby.NowStatLevel();
            if (statLevel[5] == 1)
            {
                EnhancePlayerSpeed();
            }
            else if (statLevel[5] == 2)
            {
                EnhancePlayerSpeed();
            }
            else if (statLevel[5] == 3)
            {
                EnhancePlayerSpeed();
            }

        }
    }


}