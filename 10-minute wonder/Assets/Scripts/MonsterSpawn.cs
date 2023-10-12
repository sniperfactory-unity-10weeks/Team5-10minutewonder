using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [Tooltip("각 페이즈는 2분마다 변경 (총 5개의 페이즈 존재)")]
    [Range(1, 5)]
    public int Phase = 1;

    public bool CoroutineCheck = false; //코루틴이 실행중인지 확인할 Bool 변수
    public float PhaseChangeTime = 120; //페이즈 변환 시간

    public GameObject[] MonsterPrefab; //몬스터 프리팹 저장 배열
    // 0 - Monster1
    // 1 - Monster2
    // 2 - Monster3

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //페이즈 변환 코드
        if (!CoroutineCheck)
        {
            CoroutineCheck = true;
            if(Phase < 5) StartCoroutine(ChangePhase());
        }

        switch (Phase)
        {
            case 1:
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                break;

        }


    }

    IEnumerator ChangePhase()
    {
        yield return new WaitForSeconds(PhaseChangeTime);
        Phase++;
        CoroutineCheck = false;
    }

}
