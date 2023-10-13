using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int gold = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameManager.instance.player.getGold += gold;
            Debug.Log("지금까지 모은 골드 " + GameManager.instance.player.getGold);
            Destroy(this.gameObject);
        }

    }


}
