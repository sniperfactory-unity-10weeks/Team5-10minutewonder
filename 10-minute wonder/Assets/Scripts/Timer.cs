using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    GameManager gameManager;

    public Text TimeText;
    private float countdown = 600.0f; //10�� = 600��

    public string GameClear;

    void Update()
    {
        if (countdown > 0.0f)
        {
            countdown -= Time.deltaTime;
                        
            int minutes = Mathf.FloorToInt(countdown / 60.0f); //�а� �ʷ� ��ȯ
            int seconds = Mathf.FloorToInt(countdown % 60.0f);
                        
            string timerString = string.Format("{0:00}:{1:00}", minutes, seconds); //�ð��� "00:00" ������ ���ڿ��� ��ȯ

            TimeText.text = timerString; //UI�� �ؽ�Ʈ ������Ʈ
        }
        else
        {
            TimeText.text = "00:00"; //Ÿ�̸Ӱ� 0�ʰ� �Ǹ� ���ϴ� ���� ����
            Debug.Log("�ð�����");
            SceneManager.LoadScene(GameClear); //���� Ŭ����� ȣ��
        }
    }
}
