using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerHP; //플레이어 최대 체력
    public float recoverHP; //플레이어 체력 회복량
    public float AttackDamage; //플레이어 공격력
    public float AttackSpeed; //초당 공격 속도
    //public float AttackRange = 0; // 공격 범위 (보류)
    public float PlayerSpeed; // 플레이어 이동 속도

    private Rigidbody2D playerRB;
    private float hAxis;
    private float vAxis;

    // 가까운 몬스터 추적
    private List<GameObject> FoundObjects;
    private GameObject target; //얘가 타겟임
    private float shortDis;

    // 총알 관련
    public GameObject bullet;
    private Rigidbody2D bulletRB;
    private float timeAfterSpawn;
    public static Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        /* 플레이어 프리펩쪽은 아직 손 못댔습니다.
        PlayerHP = PlayerPrefs.GetFloat("PlayerHP");
        recoverHP = PlayerPrefs.GetFloat("recoverHP");
        AttackDamage = PlayerPrefs.GetFloat("AttakDamage");
        AttackSpeed = PlayerPrefs.GetFloat("AttackSpeed");
        PlayerSpeed = PlayerPrefs.GetFloat("PlayerSpeed");
        */

        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어의 체력이 0이 되면 정지
        if (PlayerHP == 0)
        {
            playerRB.velocity = Vector3.zero;
            return;
        }

        Move();
        Attack();
    }

    // 플레이어의 이동은 newVelocity 활용
    void Move()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        float hSpeed = hAxis * PlayerSpeed;
        float vSpeed = vAxis * PlayerSpeed;

        Vector3 newVelocity = new Vector3(hSpeed, vSpeed, 0);

        playerRB.velocity = newVelocity;
    }

    void Attack()
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
        if (timeAfterSpawn >= (1 / AttackSpeed))
        {
            timeAfterSpawn = 0f;

            if (target != null) // 적이 존재 한다면
            {
                // 총알은 플레이어의 위치에서 생성
                bullet = Instantiate(bullet, transform.position, transform.rotation);

                dir = target.transform.position - transform.position; //타겟을 바라 볼 수 있게 마이너스 처리
                dir = dir.normalized; // 노말라이즈드로 방향값만 받아오기
                bullet.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir); // 불릿이 타겟을 바라보게 로테이션 돌려주기
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 몬스터 접촉 시
        if (other.tag == "Enemy")
        {
            PlayerHP -= 10f;
            Debug.Log("hit");
        }
        // 근접 공격 피격 시
        if (other.tag == "MeleeAtk")
        {
            PlayerHP -= 10f;
        }
        // 원거리 공격 피격 시
        if (other.tag == "RangedAtk")
        {
            PlayerHP -= 20f;
        }
    }
}
