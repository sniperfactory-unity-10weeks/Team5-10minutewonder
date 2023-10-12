using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIManager : MonoBehaviour
{
    public UnityEngine.UI.Button[] items;
    public Sprite[] images;

    public Image selectItem; //유물
    public Text itemName;
    public Text itemInformation;

    void Start()
    {
        /*SetAllButtonsActiveState(false); //최초에는 모든 유물 비활성화*/

        items[0].onClick.AddListener(() => OnItemClick(0, "탄창", " 탄환의 공격딜레이\n한 단계 감소"));
        items[1].onClick.AddListener(() => OnItemClick(1, "짱돌", "공격력 5 증가"));
        items[2].onClick.AddListener(() => OnItemClick(2, "가죽신발", "이동속도 1 증가"));
        items[3].onClick.AddListener(() => OnItemClick(3, "가죽갑옷", "최대체력 50 증가"));
        items[4].onClick.AddListener(() => OnItemClick(4, "회복 포션", "회복력 5 증가"));
        items[5].onClick.AddListener(() => OnItemClick(5, "<특수>파편", " 적중시키는 경우\n파편(공격력의 10%)을\n튀기는 탄환"));
        items[6].onClick.AddListener(() => OnItemClick(6, "<특수>흡혈 박쥐", " 일정 영역 안으로\n들어오는 적의 생명력을\n흡수(3초에 한 번)"));
        items[7].onClick.AddListener(() => OnItemClick(7, "<특수>삼지창", " 탄환을 세 방향으로\n발사"));
        items[8].onClick.AddListener(() => OnItemClick(8, "<특수>만년설", " 탄환에 맞은 적의\n이동속도 감소\n(2초동안 2 감소)"));
        items[9].onClick.AddListener(() => OnItemClick(9, "<특수>폭약", " 맞은 적 주변으로\n광역 피해를 입히는\n탄환"));
        items[10].onClick.AddListener(() => OnItemClick(10, "<특수>무게추", " 공격딜레이가 한 단계\n감소하지만 공격받은 적이\n뒤로 밀려나는 탄환"));
        items[11].onClick.AddListener(() => OnItemClick(11, "<특수>거울", " 공격방향의 역방향으로도\n동시에 발사되는 탄환"));
        items[12].onClick.AddListener(() => OnItemClick(12, "<특수>화살", " 적을 다섯 번 관통하는\n탄환"));
        items[13].onClick.AddListener(() => OnItemClick(13, "<특수>쥐불놀이", " 360도 회전하며 적의\n원거리 공격을 튕겨내는\n탄환"));
        //특수유물의 시간이나 소비재화는 시연 후 밸런스 조절 필요
        items[14].onClick.AddListener(() => OnItemClick(14, "<특수>고장난 위치 추적기", "탄환과 별도로\n10초마다 랜덤한 위치에\n폭탄 낙하\n(아무나 피해를 입으니\n주의)"));
        items[15].onClick.AddListener(() => OnItemClick(15, "<희귀>용의 머리 화석", " 1분마다 정면에 있는\n일반몬스터가 모두 소멸"));
        items[16].onClick.AddListener(() => OnItemClick(16, "<희귀>얼음 박쥐의 날개", " 1분마다 일정 범위 안의\n적들을 10초간 동결"));
        items[17].onClick.AddListener(() => OnItemClick(17, "<희귀>이름없는 대도의 팔찌", " 매 5초마다 반복되는\n투명상태와 해제상태\n(투명상태는 무적)"));
        items[18].onClick.AddListener(() => OnItemClick(18, "<희귀>거상의 짐꾸러미", " 획득골드가 2배가\n되지만 이동속도가\n2 감소"));
        items[19].onClick.AddListener(() => OnItemClick(19, "<희귀>매우 사치스러운 장식", " 회복력이 2배가 되지만\n30초마다 10골드씩\n소비"));

    }

    void SetButtonInfo(int index, string name, string information)
    {
        items[index].onClick.AddListener(() => OnItemClick(index, name, information));
    }

    public void OnItemClick(int index, string name, string information)
    {
        selectItem.sprite = images[index]; //버튼에 대한 인덱스를 설정
        itemName.text = name; //아이템(유물) 이름
        itemInformation.text = information; //아이템(유물) 정보
    }

    void ActiveItem(bool isActive)
    {
        foreach (var button in items)
        {
            button.gameObject.SetActive(isActive);
        }
    }

    void ActivateButtons()
    {
        // 특정 조건을 확인하고 조건이 만족되면 버튼들을 활성화
        /*
        if (특정 조건을 확인하는 로직)
        {
            ActiveItem(true);
        }
        */
    }
    }