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
        if (stat[0].gameObject.activeSelf == true)
        {
            statLevel[0] = statUpInLobby.NowStatLevel();
            
        }
        else if (stat[1].gameObject.activeSelf == true)
        {
            statLevel[1] = statUpInLobby.NowStatLevel();
            
        }
        else if (stat[2].gameObject.activeSelf == true)
        {
            statLevel[2] = statUpInLobby.NowStatLevel();
            
        }
        else if (stat[3].gameObject.activeSelf == true)
        {
            statLevel[3] = statUpInLobby.NowStatLevel();
            
        }
        else if (stat[4].gameObject.activeSelf == true)
        {
            statLevel[4] = statUpInLobby.NowStatLevel();
            
        }
        else if (stat[5].gameObject.activeSelf == true)
        {
            statLevel[5] = statUpInLobby.NowStatLevel();
            
        }

    }
}
