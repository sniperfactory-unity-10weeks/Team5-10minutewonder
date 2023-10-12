using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIManager : MonoBehaviour
{
    public UnityEngine.UI.Button[] items;
    public Sprite[] images;

    public Image selectItem; //����
    public Text itemName;
    public Text itemInformation;

    void Start()
    {
        /*SetAllButtonsActiveState(false); //���ʿ��� ��� ���� ��Ȱ��ȭ*/

        items[0].onClick.AddListener(() => OnItemClick(0, "źâ", " źȯ�� ���ݵ�����\n�� �ܰ� ����"));
        items[1].onClick.AddListener(() => OnItemClick(1, "¯��", "���ݷ� 5 ����"));
        items[2].onClick.AddListener(() => OnItemClick(2, "���׽Ź�", "�̵��ӵ� 1 ����"));
        items[3].onClick.AddListener(() => OnItemClick(3, "���װ���", "�ִ�ü�� 50 ����"));
        items[4].onClick.AddListener(() => OnItemClick(4, "ȸ�� ����", "ȸ���� 5 ����"));
        items[5].onClick.AddListener(() => OnItemClick(5, "<Ư��>����", " ���߽�Ű�� ���\n����(���ݷ��� 10%)��\nƢ��� źȯ"));
        items[6].onClick.AddListener(() => OnItemClick(6, "<Ư��>���� ����", " ���� ���� ������\n������ ���� �������\n���(3�ʿ� �� ��)"));
        items[7].onClick.AddListener(() => OnItemClick(7, "<Ư��>����â", " źȯ�� �� ��������\n�߻�"));
        items[8].onClick.AddListener(() => OnItemClick(8, "<Ư��>���⼳", " źȯ�� ���� ����\n�̵��ӵ� ����\n(2�ʵ��� 2 ����)"));
        items[9].onClick.AddListener(() => OnItemClick(9, "<Ư��>����", " ���� �� �ֺ�����\n���� ���ظ� ������\nźȯ"));
        items[10].onClick.AddListener(() => OnItemClick(10, "<Ư��>������", " ���ݵ����̰� �� �ܰ�\n���������� ���ݹ��� ����\n�ڷ� �з����� źȯ"));
        items[11].onClick.AddListener(() => OnItemClick(11, "<Ư��>�ſ�", " ���ݹ����� ���������ε�\n���ÿ� �߻�Ǵ� źȯ"));
        items[12].onClick.AddListener(() => OnItemClick(12, "<Ư��>ȭ��", " ���� �ټ� �� �����ϴ�\nźȯ"));
        items[13].onClick.AddListener(() => OnItemClick(13, "<Ư��>��ҳ���", " 360�� ȸ���ϸ� ����\n���Ÿ� ������ ƨ�ܳ���\nźȯ"));
        //Ư�������� �ð��̳� �Һ���ȭ�� �ÿ� �� �뷱�� ���� �ʿ�
        items[14].onClick.AddListener(() => OnItemClick(14, "<Ư��>���峭 ��ġ ������", "źȯ�� ������\n10�ʸ��� ������ ��ġ��\n��ź ����\n(�ƹ��� ���ظ� ������\n����)"));
        items[15].onClick.AddListener(() => OnItemClick(15, "<���>���� �Ӹ� ȭ��", " 1�и��� ���鿡 �ִ�\n�Ϲݸ��Ͱ� ��� �Ҹ�"));
        items[16].onClick.AddListener(() => OnItemClick(16, "<���>���� ������ ����", " 1�и��� ���� ���� ����\n������ 10�ʰ� ����"));
        items[17].onClick.AddListener(() => OnItemClick(17, "<���>�̸����� �뵵�� ����", " �� 5�ʸ��� �ݺ��Ǵ�\n������¿� ��������\n(������´� ����)"));
        items[18].onClick.AddListener(() => OnItemClick(18, "<���>�Ż��� ���ٷ���", " ȹ���尡 2�谡\n������ �̵��ӵ���\n2 ����"));
        items[19].onClick.AddListener(() => OnItemClick(19, "<���>�ſ� ��ġ������ ���", " ȸ������ 2�谡 ������\n30�ʸ��� 10��徿\n�Һ�"));

    }

    void SetButtonInfo(int index, string name, string information)
    {
        items[index].onClick.AddListener(() => OnItemClick(index, name, information));
    }

    public void OnItemClick(int index, string name, string information)
    {
        selectItem.sprite = images[index]; //��ư�� ���� �ε����� ����
        itemName.text = name; //������(����) �̸�
        itemInformation.text = information; //������(����) ����
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
        // Ư�� ������ Ȯ���ϰ� ������ �����Ǹ� ��ư���� Ȱ��ȭ
        /*
        if (Ư�� ������ Ȯ���ϴ� ����)
        {
            ActiveItem(true);
        }
        */
    }
    }