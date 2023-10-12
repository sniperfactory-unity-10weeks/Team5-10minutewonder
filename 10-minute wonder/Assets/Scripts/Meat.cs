using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour, Drops
{
    public float health = 25;

    public void Use(GameObject target)
    {
        // �ִ�ü�º��� ������
        if (GameManager.instance.player.currentHp < GameManager.instance.hp)
        {
            // ȸ������ ����ü�º��� ������
            if ((GameManager.instance.hp - GameManager.instance.player.currentHp) < health)
            {
                // ũ�ٸ� ����ü�¸�ŭ ȸ��
                GameManager.instance.player.currentHp
                    += (GameManager.instance.hp - GameManager.instance.player.currentHp);
            }
            else
            {
                // �۴ٸ� ȸ������ŭ ȸ��
                GameManager.instance.player.currentHp += health;
            }
        }
        Debug.Log("���!");
        Destroy(gameObject);
    }
}
