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


    public void StatUpPlayer()//��ȭ�ϱ� ��ư ������ ��
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
            playergold -= 10; //10��� �Ҹ�
            stat.statLevel[i]++;
            Debug.Log(("��ȭ�Ǿ����ϴ�. ���� ��差") + playergold);
        }
        else if (playergold < 10) //��ȭ�� ������ ���
        {
            Debug.Log(("��ȭ����.��� ����"));
        }
        else if (stat.statLevel[i] >= 3) //��ȭ 3�ܰ���� �Ϸ�� ���
        {
            Debug.Log(("�ִ� ��ȭ"));
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
        if (stat.statLevel[i] == 0) //��ȭ0��
        {
            for (int j = 0; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(true);
                StatUpComPlete[j].gameObject.SetActive(false);
            }
        }
        else if (stat.statLevel[i] == 1) //��ȭ1��
        {
            NotStatUp[0].gameObject.SetActive(false);
            StatUpComPlete[0].gameObject.SetActive(true);

            for (int j = 1; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(true);
                StatUpComPlete[j].gameObject.SetActive(false);
            }

        }
        else if (stat.statLevel[i] == 2) //��ȭ2��
        {
            NotStatUp[0].gameObject.SetActive(false);
            StatUpComPlete[0].gameObject.SetActive(true);
            NotStatUp[1].gameObject.SetActive(false);
            StatUpComPlete[1].gameObject.SetActive(true);
            NotStatUp[2].gameObject.SetActive(true);
            StatUpComPlete[2].gameObject.SetActive(false);

        }
        else if (stat.statLevel[i] == 3) //��ȭ3��
        {
            for (int j = 0; j < 3; j++)
            {
                NotStatUp[j].gameObject.SetActive(false);
                StatUpComPlete[j].gameObject.SetActive(true);
            }
        }
    }
}
