using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Monster : MonoBehaviour
{

/* MonsterType
1. 추적만 하는 유닛 (일반) : 체력 = 페이즈 x 2 / 공격력 = 10
2. 추적 + 근접 (탱커)  : 체력 = 페이즈 x 4 / 공격력 = 10
3. 추적 + 원거리 (딜러) : 체력 = 페이즈 x 1 / 공격력 = 20
 */

    [Tooltip("Monster의 타입 번호 / 1 : 일반, 2 : 탱커, 3 : 원거리")]
    [Range(1, 3)]
    public int MonsterTyoe;

    public GameObject target;
    NavMeshAgent agent;

    private float MonsterHP; //몬스터 체력
    private float MonsterAD = 10; //몬스터 공격력

    private MonsterSpawn monsterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        switch (MonsterTyoe)
        {
            case 1:
                MonsterHP = monsterSpawn.Phase * 20;
                break;

            case 2:
                MonsterHP = monsterSpawn.Phase * 40;
                break;

            case 3:
                MonsterHP = monsterSpawn.Phase * 10;
                MonsterAD = 20;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

        //추적(고정)
        agent.destination = target.transform.position;

    }
}
