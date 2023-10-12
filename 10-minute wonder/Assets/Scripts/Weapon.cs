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

    public float AttackSpeed; //�ʴ� ���� �ӵ�

    // ����� ���� ����
    private List<GameObject> FoundObjects;
    private GameObject target; //�갡 Ÿ����
    private float shortDis;

    // �Ѿ� ����
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
        // FoundObjects��� ����Ʈ���� �±װ� Enemy�� ���ӿ�����Ʈ�� ��ƵѰ���
        FoundObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        // �÷��̾�� ���� ������ �ִܰŸ� ����
        shortDis = Vector3.Distance(gameObject.transform.position, FoundObjects[0].transform.position);

        target = FoundObjects[0];

        foreach (GameObject found in FoundObjects) // FoundObjects�� ���ӿ�����Ʈ�� ���ö����� ����
        {
            //���� ���� ������Ʈ���� �Ÿ� ����
            float Distance = Vector3.Distance(gameObject.transform.position, found.transform.position);

            if (Distance < shortDis) //ó�� Ÿ������ ���ͺ��� �� �����ٸ�
            {
                target = found; // ���� ���� ������Ʈ�� Ÿ������ ����
                shortDis = Distance; // �ִܰŸ��� ���� �ʱ�ȭ
            }
        }

        timeAfterSpawn += Time.deltaTime;
        // �ʴ� ���� ��Ŀ����
        if (timeAfterSpawn >= (1 / AttackSpeed) && target != null)
        {
            timeAfterSpawn = 0;

            bullets[currrntIndex].SetActive(true);
            bullets[currrntIndex].transform.position = transform.position; // �Ѿ��� �÷��̾��� ��ġ���� ����

            dir = target.transform.position - transform.position; //Ÿ���� �ٶ� �� �� �ְ� ���̳ʽ� ó��
            dir = dir.normalized; // �븻�������� ���Ⱚ�� �޾ƿ���
            bullets[currrntIndex].transform.rotation = Quaternion.FromToRotation(Vector3.up, dir); // �Ҹ��� Ÿ���� �ٶ󺸰� �����̼� �����ֱ�

            currrntIndex++;

            if (currrntIndex >= count)
            {
                currrntIndex = 0;
            }
        }
    }
}
