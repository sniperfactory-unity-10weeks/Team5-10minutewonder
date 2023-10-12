using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("�� ������� 2�и��� ���� (�� 5���� ������ ����)")]
    [Range(1, 5)]
    public int Phase = 1;

    public bool CoroutineCheck = false; //�ڷ�ƾ�� ���������� Ȯ���� Bool ����
    public float PhaseChangeTime = 120; //������ ��ȯ �ð�

    public Transform[] spawnPoint;

    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        //������ ��ȯ �ڵ�
        if (!CoroutineCheck)
        {
            CoroutineCheck = true;
            if (Phase < 5) StartCoroutine(ChangePhase());
        }

        timer += Time.deltaTime;

        if (timer > 0.2f)
        {
            timer = 0;
            Spawn();
        }


    }

    void Spawn()
    {
        GameObject enemy = null;
        switch (Phase)
        {

            case 1:
                enemy = GameManager.instance.pool.Get(0);
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
>>>>>>> Stashed changes
                break;

            case 2:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 2));
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
>>>>>>> Stashed changes
                break;

            case 3:
                int Randnum = Random.Range(0, 2);
                if (Randnum == 0) enemy = GameManager.instance.pool.Get(0);
                else enemy = GameManager.instance.pool.Get(2);
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
>>>>>>> Stashed changes
                break;

            case 4:
                enemy = GameManager.instance.pool.Get(Random.Range(1, 3));
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
>>>>>>> Stashed changes
                break;

            case 5:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 3));
<<<<<<< Updated upstream
                break;

        }
         enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //�ڱ��ڽ� 0�� ����
                break;

        }

>>>>>>> Stashed changes
    }

    IEnumerator ChangePhase()
    {
        yield return new WaitForSeconds(PhaseChangeTime);
        Phase++;
        CoroutineCheck = false;
    }
}
