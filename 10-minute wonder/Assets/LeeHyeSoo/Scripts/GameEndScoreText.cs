using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndScoreText : MonoBehaviour
{
    GameManager gameManager;

    public Text timeText; //플레이시간 텍스트
    public Text killText; //몬스터 처치 수 텍스트
    public Text goldText; //획득한 골드 텍스트

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        timeText.text = gameManager.playTime.ToString();
        killText.text = gameManager.kill.ToString() + " 마리";
        goldText.text = gameManager.goldScore.ToString() + " G";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
