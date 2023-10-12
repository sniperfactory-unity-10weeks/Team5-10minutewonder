using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelUp : MonoBehaviour
{
    RandomItem randomItem;
    public GameObject itemLevelUpWindow; // ������ �� / ������ ��ȭ
    public GameObject playerStatWindow; // ĳ���� ����â
    bool isPause; //�÷��� ȭ�� �Ͻ�����

    public Spawner spawner;

    private void Start()
    {
        randomItem = FindAnyObjectByType<RandomItem>(); 

        itemLevelUpWindow.SetActive(false);
        isPause = false;
    }

    private void Update()
    {
        //(�ӽ�)T�� ������ ����â�� �ߵ���
        //���߿� ������ ���������� �ߵ��� �Ѵ�

        if (spawner.isChangePhase) 
        {
            spawner.isChangePhase = false;
            Time.timeScale = 0;
            itemLevelUpWindow.SetActive(true);
            randomItem.GetRandomItem();
            Debug.Log("�Ͻ����� Ȱ��ȭ");
            isPause = true;
            Debug.Log("���� ������");
        }


        //����! => ������ ������ ��Ȱ��ȭ
        //�Ͻ����� ��Ȱ��ȭ
        if (Input.GetKeyDown(KeyCode.T) && isPause == true)
        {
            Time.timeScale = 1;
            itemLevelUpWindow.SetActive(false);
            isPause = false;
            Debug.Log("�Ͻ����� Ȱ��ȭ");
            return;
        }


    }

    public void PlayerStatWindowInGame()
    {
        playerStatWindow.SetActive(true);
        itemLevelUpWindow.SetActive(false);
        isPause = false;
    }

    void ItemlevelUp()
    {
        if(itemLevelUpWindow)
        {

        }
        else
        {

        }
    }
}
