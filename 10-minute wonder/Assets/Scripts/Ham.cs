using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ham : MonoBehaviour
{
    public float health = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            GameManager.instance.player.currentHp += health;
            if (GameManager.instance.player.currentHp > GameManager.instance.player.PlayerHP)
                GameManager.instance.player.currentHp = GameManager.instance.player.PlayerHP;

            Debug.Log("ÇÜ!");
            Destroy(this.gameObject);
        }

    }
}
