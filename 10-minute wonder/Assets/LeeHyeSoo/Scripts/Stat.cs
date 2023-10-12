using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    StatUpInLobby statUpInLobby;

    public GameObject[] stat;
    public int[] statLevel = new int[6];

    private void Start()
    {
        statUpInLobby = GameObject.FindAnyObjectByType<StatUpInLobby>();
        
        for(int i = 0; i < statLevel.Length; i++)
        {
            statLevel[i] = 0;
        }
    }

    private void Update()
    {
        //if(stat[0].name == "HP" && gameObject.)
        //{
        //    statLevel[0] = statUpInLobby.NowStatLevel();
        //}
        //else if (stat[1].name == "recover" && stat[1])
        //{
        //    statLevel[1] = statUpInLobby.NowStatLevel();
        //}
        //else if (stat[2].name == "attckPower" && stat[2])
        //{
        //    statLevel[2] = statUpInLobby.NowStatLevel();
        //}
        //else if (stat[3].name == "attackCoolTime" && stat[3])
        //{
        //    statLevel[3] = statUpInLobby.NowStatLevel();
        //}
        //else if (stat[4].name == "attackRange" && stat[4])
        //{
        //    statLevel[4] = statUpInLobby.NowStatLevel();
        //}
        //else if (stat[5].name == "moveSpeed" && stat[5])
        //{
        //    statLevel[5] = statUpInLobby.NowStatLevel();
        //}

    }
}
