using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour, Drops
{
    public int gold = 10;

    public void Use(GameObject target)
    {
        GameManager.instance.player.getGold += gold;
        Debug.Log("지금까지 모은 골드 " + GameManager.instance.player.getGold);
        Destroy(gameObject);
    }
}
