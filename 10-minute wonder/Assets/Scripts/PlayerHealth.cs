using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    GameManager gameManager;

    public Slider healthSlider; //�����̴� ������Ʈ �Ҵ�

    public string GameClear;
    /*
    protected override void OnEnable()
    {
        healthSlider.gameObject.SetActive(true); //ü�� �����̴� Ȱ��ȭ
        healthSlider.maxValue = startingHealth; //ü�� �����̴��� �ִ��� �⺻ ü�°����� ����
        healthSlider.value = health; //ü�� �����̴��� ���� ���� ü�°����� ����
    }


    public override void Die()
    {
        base.Die();
        Time.timeScale = 0f //���� Ÿ�̸� ����
        healthSlider.gameObject.SetActive(false); //ü�� �����̴� ��Ȱ��ȭ
        SceneManager.LoadScene(GameClear); //���� Ŭ����� ȣ��
    }
    */
}
