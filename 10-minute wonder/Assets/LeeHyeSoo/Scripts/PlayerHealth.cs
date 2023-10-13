using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider hp_slider;

    GameManager gameManager;
    Player player;

    float maxhp;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
        gameManager = FindAnyObjectByType<GameManager>();

        hp_slider = FindAnyObjectByType<Slider>();
        hp_slider.minValue = 0;


    }
    void Update()
    {
        hp_slider.maxValue = player.PlayerHP;//�����̴��� �ִ밪�� ������ �ִ�ü������ ����
        hp_slider.value = player.currentHp;//�����̴��� ���� ������ ü������ ����


    }
}
