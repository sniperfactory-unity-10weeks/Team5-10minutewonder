using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text timeScore; // 제한 시간 텍스트
    public Text killScore; // 처치한 몬스터 수 텍스트
    public Text goldScore; // 획득한 골드량 텍스트
    


    //게임 플레이에서 획득한 점수 전달 받기
    public void AddScore(int hour,int min,int kill,int gold) //시간 / 분 / 몬스터 처치수 / 획득한 골드량
    {
        timeScore.text = hour + ":" + min;
        killScore.text = kill + " 마리";
        goldScore.text = gold + " G";

    }
}
