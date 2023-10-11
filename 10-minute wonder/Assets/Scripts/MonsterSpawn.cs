using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [Tooltip("�� ������� 2�и��� ���� (�� 5���� ������ ����)")]
    [Range(1, 5)]
    public int Phase = 1;

    public bool CoroutineCheck = false; //�ڷ�ƾ�� ���������� Ȯ���� Bool ����
    public float PhaseChangeTime = 120; //������ ��ȯ �ð�

    public GameObject[] MonsterPrefab; //���� ������ ���� �迭
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
        //������ ��ȯ �ڵ�
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
