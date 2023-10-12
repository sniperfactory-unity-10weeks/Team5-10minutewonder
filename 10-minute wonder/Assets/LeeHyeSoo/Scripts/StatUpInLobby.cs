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

    public void StatUpPlayer()//강화하기 버튼 눌렀을 때
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
            playergold -= 10; //10골드 소모
            playerstatLevel++;
            Debug.Log(("강화되었습니다. 현재 골드량") + playergold);
        }
        else if (playergold < 10) //재화가 부족한 경우
        {
            Debug.Log(("강화실패.골드 부족"));
        }
        else if (playerstatLevel == 3) //강화 3단계까지 완료된 경우
        {
            Debug.Log(("최대 강화"));
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
