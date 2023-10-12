using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelUp : MonoBehaviour
{
    public GameObject itemLevelUpWindow; // 페이즈 끝 / 아이템 강화
    public GameObject playerStatWindow; // 캐릭터 스텟창
    bool isPause; //플레이 화면 일시정지

    RandomItem randomItem;

    private void Start()
    {
        randomItem = FindAnyObjectByType<RandomItem>();

        itemLevelUpWindow.SetActive(false);
        isPause = false;
    }

    private void Update()
    {
        //(임시)T를 누르면 상태창이 뜨도록
        //나중에 페이즈 끝날때마다 뜨도록 한다

        if (Input.GetKeyDown(KeyCode.T)) 
        {
            Debug.Log("다음 페이즈");

            //일시정지 활성화
            if (isPause == false)
            {
                Time.timeScale = 0;
                itemLevelUpWindow.SetActive(true);
                randomItem.GetRandomItem(); //랜덤으로 아이템(유물) 3가지 정해짐

                isPause = true;
                


                Debug.Log("일시정지 활성화");

                return;


            }

            //일시정지 비활성화
            if (isPause == true)
            {
                Time.timeScale = 1;
                itemLevelUpWindow.SetActive(false);
                isPause = false;
                Debug.Log("일시정지 활성화");
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
