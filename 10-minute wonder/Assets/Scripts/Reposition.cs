using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area")) return;

        //플레이어의 위치
        Vector3 playerPos = GameManager.instance.player.transform.position;
        //타일맵의 위치
        Vector3 myPos = this.transform.position;

        //차잇값 계산
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 PlayerDir = GameManager.instance.player.newVelocity;
        float dirX = PlayerDir.x < 0 ? -1 : 1; //벡터 정규화시 1보다 작게 나오는 것 방지
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
                break;
        }

    }
}
