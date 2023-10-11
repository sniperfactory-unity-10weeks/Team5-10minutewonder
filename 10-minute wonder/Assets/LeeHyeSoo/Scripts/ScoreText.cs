using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text timeScore; // ���� �ð� �ؽ�Ʈ
    public Text killScore; // óġ�� ���� �� �ؽ�Ʈ
    public Text goldScore; // ȹ���� ��差 �ؽ�Ʈ
    


    //���� �÷��̿��� ȹ���� ���� ���� �ޱ�
    public void AddScore(int hour,int min,int kill,int gold) //�ð� / �� / ���� óġ�� / ȹ���� ��差
    {
        timeScore.text = hour + ":" + min;
        killScore.text = kill + " ����";
        goldScore.text = gold + " G";

    }
}
