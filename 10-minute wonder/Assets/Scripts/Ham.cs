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
            Debug.Log("��!");
            Destroy(this.gameObject);
        }

    }
}
