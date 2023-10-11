using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndScoreText : MonoBehaviour
{
    GameManager gameManager;

    public Text timeText; //�÷��̽ð� �ؽ�Ʈ
    public Text killText; //���� óġ �� �ؽ�Ʈ
    public Text goldText; //ȹ���� ��� �ؽ�Ʈ

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        timeText.text = gameManager.playTime.ToString();
        killText.text = gameManager.kill.ToString() + " ����";
        goldText.text = gameManager.goldScore.ToString() + " G";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
