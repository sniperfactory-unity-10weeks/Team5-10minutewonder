using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerHP; //�÷��̾� �ִ� ü��
    public float recoverHP; //�÷��̾� ü�� ȸ����
    public float AttackDamage; //�÷��̾� ���ݷ�
    public float AttackSpeed; //�ʴ� ���� �ӵ�
    //public float AttackRange = 0; // ���� ���� (����)
    public float PlayerSpeed; // �÷��̾� �̵� �ӵ�

    private Rigidbody2D playerRB;
    private float hAxis;
    private float vAxis;

    // ����� ���� ����
    private List<GameObject> FoundObjects;
    private GameObject target; //�갡 Ÿ����
    private float shortDis;

    // �Ѿ� ����
    public GameObject bullet;
    private Rigidbody2D bulletRB;
    private float timeAfterSpawn;
    public static Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        /* �÷��̾� ���������� ���� �� ������ϴ�.
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
        // �÷��̾��� ü���� 0�� �Ǹ� ����
        if (PlayerHP == 0)
        {
            playerRB.velocity = Vector3.zero;
            return;
        }

        Move();
        Attack();
    }

    // �÷��̾��� �̵��� newVelocity Ȱ��
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
        if (timeAfterSpawn >= (1 / AttackSpeed))
        {
            timeAfterSpawn = 0f;

            if (target != null) // ���� ���� �Ѵٸ�
            {
                // �Ѿ��� �÷��̾��� ��ġ���� ����
                bullet = Instantiate(bullet, transform.position, transform.rotation);

                dir = target.transform.position - transform.position; //Ÿ���� �ٶ� �� �� �ְ� ���̳ʽ� ó��
                dir = dir.normalized; // �븻�������� ���Ⱚ�� �޾ƿ���
                bullet.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir); // �Ҹ��� Ÿ���� �ٶ󺸰� �����̼� �����ֱ�
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // ���� ���� ��
        if (other.tag == "Enemy")
        {
            PlayerHP -= 10f;
            Debug.Log("hit");
        }
        // ���� ���� �ǰ� ��
        if (other.tag == "MeleeAtk")
        {
            PlayerHP -= 10f;
        }
        // ���Ÿ� ���� �ǰ� ��
        if (other.tag == "RangedAtk")
        {
            PlayerHP -= 20f;
        }
    }
}
