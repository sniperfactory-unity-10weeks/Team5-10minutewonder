using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ham : MonoBehaviour, Drops
{
    public float health = 50;

    public void Use(GameObject target)
    {
        // 최대체력보다 적은가
        if (GameManager.instance.player.currentHp < GameManager.instance.hp)
        {
            // 회복량이 남은체력보다 작은가
            if ((GameManager.instance.hp - GameManager.instance.player.currentHp) < health)
            {
                // 크다면 남은체력만큼 회복
                GameManager.instance.player.currentHp
                    += (GameManager.instance.hp - GameManager.instance.player.currentHp);
            }
            else
            {
                // 작다면 회복량만큼 회복
                GameManager.instance.player.currentHp += health;
            }
        }
        Debug.Log("햄!");
        Destroy(gameObject);
    }
}
