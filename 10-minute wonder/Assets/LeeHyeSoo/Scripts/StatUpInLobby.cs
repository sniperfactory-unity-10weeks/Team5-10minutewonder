using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUpInLobby : MonoBehaviour
{
    GameManager gameManager;
    Stat stat;
    public int playergold;

    public GameObject[] NotStatUp = new GameObject[3];
    public GameObject[] StatUpComPlete = new GameObject[3];

    public bool isRef;

    public int NowGold()
    {
        return playergold;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find(name: "GameManager").GetComponent<GameManager>();
        stat = GameObject.FindAnyObjectByType<Stat>();

        playergold = gameManager.gold;

    }

    private void Update()
    {
        if (stat.stat[0].gameObject.activeSelf == true)
        {
            StatUpStarImage(0);

        }
        else if (stat.stat[1].gameObject.activeSelf == true)
        {
            StatUpStarImage(1);

        }
        else if (stat.stat[2].gameObject.activeSelf == true)
        {
            StatUpStarImage(2);

        }
        else if (stat.stat[3].gameObject.activeSelf == true)
        {
            StatUpStarImage(3);

        }
        else if (stat.stat[4].gameObject.activeSelf == true)
        {
            StatUpStarImage(4);

        }
        else if (stat.stat[5].gameObject.activeSelf == true)
        {
            StatUpStarImage(5);
        }

    }


    public void StatUpPlayer()//강화하기 버튼 눌렀을 때
    {
        isRef = true;
        if (stat.stat[0].gameObject.activeSelf == true)
        {
            StatUpButton(0);

        }
        else if (stat.stat[1].gameObject.activeSelf == true)
        {
            StatUpButton(1);

        }
        else if (stat.stat[2].gameObject.activeSelf == true)
        {
            StatUpButton(2);

        }
        else if (stat.stat[3].gameObject.activeSelf == true)
        {
            StatUpButton(3);

        }
        else if (stat.stat[4].gameObject.activeSelf == true)
        {
            StatUpButton(4);

        }
        else if (stat.stat[5].gameObject.activeSelf == true)
        {
            StatUpButton(5);
        }


    }

    void StatUpButton(int i)
    {

        if (playergold >= 10 && stat.statLevel[i] <= 3)
        {
            playergold -= 10; //10골드 소모
            stat.statLevel[i]++;
            Debug.Log(("강화되었습니다. 현재 골드량") + playergold);
        }
        else if (playergold < 10) //재화가 부족한 경우
        {
            Debug.Log(("강화실패.골드 부족"));
        }
        else if (stat.statLevel[i] >= 3) //강화 3단계까지 완료된 경우
        {
            Debug.Log(("최대 강화"));
        }
    }

    

    public int NowStatLevel()
    {
        if (stat.stat[0].gameObject.activeSelf == true)
        {
            return stat.statLevel[0];

        }
        else if (stat.stat[1].gameObject.activeSelf == true)
        {
            return stat.statLevel[1];

        }
        else if (stat.stat[2].gameObject.activeSelf == true)
        {
            return stat.statLevel[2];

        }
        else if (stat.stat[3].gameObject.activeSelf == true)
        {
            return stat.statLevel[3];

        }
        else if (stat.stat[4].gameObject.activeSelf == true)
        {
            return stat.statLevel[4];

        }
        else if (stat.stat[5].gameObject.activeSelf == true)
        {
            return stat.statLevel[5];
        }
        else { return 0; }
    }

    void StatUpStarImage(int i)
    {
        if (stat.statLevel[i] == 0) //강화0별
        {
            for (int j = 0; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(true);
                StatUpComPlete[j].gameObject.SetActive(false);
            }
        }
        else if (stat.statLevel[i] == 1) //강화1별
        {
            NotStatUp[0].gameObject.SetActive(false);
            StatUpComPlete[0].gameObject.SetActive(true);

            for (int j = 1; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(true);
                StatUpComPlete[j].gameObject.SetActive(false);
            }

        }
        else if (stat.statLevel[i] == 2) //강화2별
        {
            NotStatUp[0].gameObject.SetActive(false);
            StatUpComPlete[0].gameObject.SetActive(true);
            NotStatUp[1].gameObject.SetActive(false);
            StatUpComPlete[1].gameObject.SetActive(true);
            NotStatUp[2].gameObject.SetActive(true);
            StatUpComPlete[2].gameObject.SetActive(false);

        }
        else if (stat.statLevel[i] == 3) //강화3별
        {
            for (int j = 0; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(false);
                StatUpComPlete[j].gameObject.SetActive(true);
            }
        }
    }
}
