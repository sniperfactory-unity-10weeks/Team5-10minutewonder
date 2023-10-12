using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("각 페이즈는 2분마다 변경 (총 5개의 페이즈 존재)")]
    [Range(1, 5)]
    public int Phase = 1;

    public bool CoroutineCheck = false; //코루틴이 실행중인지 확인할 Bool 변수
    public float PhaseChangeTime = 120; //페이즈 변환 시간

    public Transform[] spawnPoint;

    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        //페이즈 변환 코드
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
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
>>>>>>> Stashed changes
                break;

            case 2:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 2));
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
>>>>>>> Stashed changes
                break;

            case 3:
                int Randnum = Random.Range(0, 2);
                if (Randnum == 0) enemy = GameManager.instance.pool.Get(0);
                else enemy = GameManager.instance.pool.Get(2);
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
>>>>>>> Stashed changes
                break;

            case 4:
                enemy = GameManager.instance.pool.Get(Random.Range(1, 3));
<<<<<<< Updated upstream
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
>>>>>>> Stashed changes
                break;

            case 5:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 3));
<<<<<<< Updated upstream
                break;

        }
         enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
=======
                enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //자기자신 0에 포함
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
