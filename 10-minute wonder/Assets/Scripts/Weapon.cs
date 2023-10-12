using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject[] bullets;
    public int count = 10;

    private List<GameObject> bulletPrefabs = new List<GameObject>();
    private int currrntIndex = 0;

    public float AttackSpeed; //초당 공격 속도

    // 가까운 몬스터 추적
    private List<GameObject> FoundObjects;
    private GameObject target; //얘가 타겟임
    private float shortDis;

    // 총알 관련
    private float timeAfterSpawn;
    public static Vector3 dir;

    private void Start()
    {
        bullets = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
        }
    }

    private void Update()
    {
        // FoundObjects라는 리스트에는 태그가 Enemy인 게임오브젝트만 담아둘것임
        FoundObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        // 플레이어와 몬스터 사이의 최단거리 측정
        shortDis = Vector3.Distance(gameObject.transform.position, FoundObjects[0].transform.position);

        target = FoundObjects[0];

        foreach (GameObject found in FoundObjects) // FoundObjects에 게임오브젝트가 들어올때마다 실행
        {
            //새로 들어온 오브젝트와의 거리 측정
            float Distance = Vector3.Distance(gameObject.transform.position, found.transform.position);

            if (Distance < shortDis) //처음 타게팅한 몬스터보다 더 가깝다면
            {
                target = found; // 새로 들어온 오브젝트를 타겟으로 변경
                shortDis = Distance; // 최단거리도 새로 초기화
            }
        }

        timeAfterSpawn += Time.deltaTime;
        // 초당 공격 메커니즘
        if (timeAfterSpawn >= (1 / AttackSpeed) && target != null)
        {
            timeAfterSpawn = 0;

            bullets[currrntIndex].SetActive(true);
            bullets[currrntIndex].transform.position = transform.position; // 총알은 플레이어의 위치에서 생성

            dir = target.transform.position - transform.position; //타겟을 바라 볼 수 있게 마이너스 처리
            dir = dir.normalized; // 노말라이즈드로 방향값만 받아오기
            bullets[currrntIndex].transform.rotation = Quaternion.FromToRotation(Vector3.up, dir); // 불릿이 타겟을 바라보게 로테이션 돌려주기

            currrntIndex++;

            if (currrntIndex >= count)
            {
                currrntIndex = 0;
            }
        }
    }
}
