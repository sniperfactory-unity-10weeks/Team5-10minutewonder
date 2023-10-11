using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMap : MonoBehaviour
{
    public GameObject[] map; // �� �����̹��� �ε���
    public GameObject selectMap; //���� ���õ� ��
    int selectMapNum = 0; //���� ���õ� �� ��ȣ

    private void Start()
    {
        selectMap = map[0];

        
    }

    public void MapRightArrow()
    {
        Debug.Log("�� ������ ��ư");
        if (selectMap == map[0])
        {
            selectMap = map[1];
        }
        else if (selectMap == map[1])
        {
            selectMap = map[2];
        }
        else if (selectMap == map[2])
        {
            selectMap = map[0];
        }
    }

    public void MapLeftArrow()
    {
        Debug.Log("�� ���� ��ư");
        if (selectMap == map[0])
        {
            selectMap = map[2];
        }
        else if (selectMap == map[2])
        {
            selectMap = map[1];
        }
        else if (selectMap == map[1])
        {
            selectMap = map[0];
        }
    }

    private void Update()
    {
        if (selectMap == map[0])
        {
            map[0].SetActive(true);
            map[1].SetActive(false);
            map[2].SetActive(false);

            selectMapNum = 1;
        }
        else if (selectMap == map[1])
        {
            map[0].SetActive(false);
            map[1].SetActive(true);
            map[2].SetActive(false);

            selectMapNum = 2;
        }
        else if (selectMap == map[2])
        {
            map[0].SetActive(false);
            map[1].SetActive(false);
            map[2].SetActive(true);

            selectMapNum = 3;
        }
    }

    public int selectMapNumber()
    {
        return selectMapNum; // �� ��ȣ ��ȯ (for �÷��̿� ����)
    }
}
