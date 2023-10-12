using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RandomItem : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    int[] selectItem = new int[4];

    public Image image1;
    public Image image2;
    public Image image3;

    public Text text1;
    public Text text2;
    public Text text3;

    private void Start()
    {
        image1 = GetComponent<Image>();
        image2 = GetComponent<Image>();
        image3 = GetComponent<Image>();
        text1 = GetComponent<Text>();
        text2 = GetComponent<Text>();
        text3 = GetComponent<Text>();
    }

    public void GetRandomItem() //페이즈가 끝날시
    {
        int[] itemNum = new int[4];

        for (int i = 0; i < items.Count; i++)
        {
            itemNum[i] = Random.Range(0, items.Count); //랜덤변수



            selectItem[i] = itemNum[i]; //랜덤변수 저장
        }

        image1.sprite = items[selectItem[0]].itemImage;
        text1.text = items[selectItem[0]].itemMemo.ToString();

        image2.sprite = items[selectItem[1]].itemImage;
        text2.text = items[selectItem[1]].itemMemo.ToString();

        image3.sprite = items[selectItem[2]].itemImage;
        text3.text = items[selectItem[2]].itemMemo.ToString();


    }

}
