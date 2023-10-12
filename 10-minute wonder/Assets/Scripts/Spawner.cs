using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [Tooltip("∆‰¿Ã¡Ó(1~5)")]
    [Range(1, 5)]
    public int Phase = 1;

    public bool CoroutineCheck = false; 
    public float PhaseChangeTime = 120; 

    public Transform[] spawnPoint;

    float timer;

    public float spawnTime;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        //?????? ??? ???
        if (!CoroutineCheck)
        {
            CoroutineCheck = true;
            if (Phase < 5) StartCoroutine(ChangePhase());
        }

        timer += Time.deltaTime;

        if (timer > spawnTime)
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
                break;

            case 2:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 2));
                break;

            case 3:
                int Randnum = Random.Range(0, 2);
                if (Randnum == 0) enemy = GameManager.instance.pool.Get(0);
                else enemy = GameManager.instance.pool.Get(2);
                break;

            case 4:
                enemy = GameManager.instance.pool.Get(Random.Range(1, 3));
                break;

            case 5:
                enemy = GameManager.instance.pool.Get(Random.Range(0, 3));
                break;

        }
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; 
    }

    IEnumerator ChangePhase()
    {
        yield return new WaitForSeconds(PhaseChangeTime);
        Phase++;
        CoroutineCheck = false;
    }
}