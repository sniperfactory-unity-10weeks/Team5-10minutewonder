using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    GameManager gameManager;

    public Slider healthSlider; //슬라이더 컴포넌트 할당

    public string GameClear;
    /*
    protected override void OnEnable()
    {
        healthSlider.gameObject.SetActive(true); //체력 슬라이더 활성화
        healthSlider.maxValue = startingHealth; //체력 슬라이더의 최댓값을 기본 체력값으로 변경
        healthSlider.value = health; //체력 슬라이더의 값을 현재 체력값으로 변경
    }


    public override void Die()
    {
        base.Die();
        Time.timeScale = 0f //게임 타이머 중지
        healthSlider.gameObject.SetActive(false); //체력 슬라이더 비활성화
        SceneManager.LoadScene(GameClear); //게임 클리어씬 호출
    }
    */
}
