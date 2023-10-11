using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Monster : MonoBehaviour
{

/* MonsterType
1. ������ �ϴ� ���� (�Ϲ�) : ü�� = ������ x 2 / ���ݷ� = 10
2. ���� + ���� (��Ŀ)  : ü�� = ������ x 4 / ���ݷ� = 10
3. ���� + ���Ÿ� (����) : ü�� = ������ x 1 / ���ݷ� = 20
 */

    [Tooltip("Monster�� Ÿ�� ��ȣ / 1 : �Ϲ�, 2 : ��Ŀ, 3 : ���Ÿ�")]
    [Range(1, 3)]
    public int MonsterTyoe;

    public GameObject target;
    NavMeshAgent agent;

    private float MonsterHP; //���� ü��
    private float MonsterAD = 10; //���� ���ݷ�

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

        //����(����)
        agent.destination = target.transform.position;

    }
}
