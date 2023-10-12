using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelUp : MonoBehaviour
{
    public GameObject itemLevelUpWindow; // ������ �� / ������ ��ȭ
    public GameObject playerStatWindow; // ĳ���� ����â
    bool isPause; //�÷��� ȭ�� �Ͻ�����

    RandomItem randomItem;

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

        if (Input.GetKeyDown(KeyCode.T)) 
        {
            Debug.Log("���� ������");

            //�Ͻ����� Ȱ��ȭ
            if (isPause == false)
            {
                Time.timeScale = 0;
                itemLevelUpWindow.SetActive(true);
                randomItem.GetRandomItem(); //�������� ������(����) 3���� ������

                isPause = true;
                


                Debug.Log("�Ͻ����� Ȱ��ȭ");

                return;


            }

            //�Ͻ����� ��Ȱ��ȭ
            if (isPause == true)
            {
                Time.timeScale = 1;
                itemLevelUpWindow.SetActive(false);
                isPause = false;
                Debug.Log("�Ͻ����� Ȱ��ȭ");
                return;
            }
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
