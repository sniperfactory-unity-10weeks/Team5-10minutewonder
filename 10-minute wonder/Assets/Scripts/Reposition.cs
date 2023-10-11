using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    Collider2D colider;

    private void Awake()
    {
        colider = GetComponent<Collider2D>();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area")) return;

        //�÷��̾��� ��ġ
        Vector3 playerPos = GameManager.instance.player.transform.position;
        //Ÿ�ϸ��� ��ġ
        Vector3 myPos = this.transform.position;

        //���հ� ���
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 PlayerDir = GameManager.instance.player.newVelocity;
        float dirX = PlayerDir.x < 0 ? -1 : 1; //���� ����ȭ�� 1���� �۰� ������ �� ����
        float dirY = PlayerDir.y < 0 ? -1 : 1;

        switch (transform.tag)
        {
            case "Ground":
                if (diffX > diffY)
                {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if (diffX < diffY)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                }
                break;

            case "Enemy":
                /*if (colider.enabled)
                {
                    transform.Translate(PlayerDir * 20 + new Vector3(Random.Range(-3f, 3f),
                        Random.Range(-3f, 3f), 0f)); 
                }*/
                break;
        }

    }
}
