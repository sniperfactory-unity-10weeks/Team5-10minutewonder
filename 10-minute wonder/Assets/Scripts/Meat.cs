using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    public float health = 25;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player")
        {

            GameManager.instance.player.currentHp += health;
            if (GameManager.instance.player.currentHp > GameManager.instance.player.PlayerHP)
                GameManager.instance.player.currentHp = GameManager.instance.player.PlayerHP;

            Debug.Log("°í±â!");
            Destroy(gameObject);
        }

    }
}
