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
        hp_slider.maxValue = player.PlayerHP;//슬라이더의 최대값을 스텟의 최대체력으로 지정
        hp_slider.value = player.currentHp;//슬라이더의 값을 스텟의 체력으로 지정


    }
}
