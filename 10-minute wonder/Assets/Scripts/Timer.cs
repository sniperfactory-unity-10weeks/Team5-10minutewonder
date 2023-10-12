using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    GameManager gameManager;

    public Text TimeText;
    private float countdown = 600.0f; //10분 = 600초

    public string GameClear;

    void Update()
    {
        if (countdown > 0.0f)
        {
            countdown -= Time.deltaTime;
                        
            int minutes = Mathf.FloorToInt(countdown / 60.0f); //분과 초로 변환
            int seconds = Mathf.FloorToInt(countdown % 60.0f);
                        
            string timerString = string.Format("{0:00}:{1:00}", minutes, seconds); //시간을 "00:00" 형식의 문자열로 변환

            TimeText.text = timerString; //UI에 텍스트 업데이트
        }
        else
        {
            TimeText.text = "00:00"; //타이머가 0초가 되면 원하는 동작 수행
            Debug.Log("시간종료");
            SceneManager.LoadScene(GameClear); //게임 클리어씬 호출
        }
    }
}
