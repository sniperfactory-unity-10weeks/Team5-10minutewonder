using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //게임 매니저에 저장되어있는 스텟치 받아오기
    public float PlayerHP;
    public float recoverHP;
    public float AttackDamage;
    public float AttackSpeed;
    public float PlayerSpeed;

    // 체력 관련
    public float currentHp;
    private float healTerm = 5;
    private float currentHealTime;

    public Vector3 newVelocity;
    private Rigidbody2D playerRB;
    public Vector3 Axis;

    SpriteRenderer sprite;
    Animator anim;
    public Scanner scanner;

    public Monster monster;

    public int getGold = 0;

    public static Player instance;

    public string GameOver;
    public bool gameStart = true;

    // Start is called before the first frame update
    void Awake()
    {

        playerRB = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        scanner = GetComponent<Scanner>();
        anim = GetComponent<Animator>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {

    }

    void Update()
    {
        if (gameStart)
        {
            gameStart = false;

        }

        Axis.x = Input.GetAxis("Horizontal");
        Axis.y = Input.GetAxis("Vertical");

        if (currentHp < 0)
        {
            PlayerDie();
        }
    }

    void FixedUpdate()
    {
        // 플레이어의 체력이 0이 되면 정지
        if (currentHp <= 0)
        {
            playerRB.velocity = Vector3.zero;
            return;
        }

        currentHealTime = Time.deltaTime;

        if (currentHealTime >= healTerm)
        {
            currentHealTime = 0;
            if (currentHp <= PlayerHP)
            {
                currentHp += recoverHP;
                Debug.Log(currentHp);
            }
        }

        float hSpeed = Axis.x * PlayerSpeed;
        float vSpeed = Axis.y * PlayerSpeed;

        newVelocity = new Vector3(hSpeed, vSpeed, 0);

        playerRB.velocity = newVelocity;
    }

    void LateUpdate()
    {
        anim.SetFloat("Speed", Axis.magnitude);
        if (Axis.x != 0)
        {
            sprite.flipX = Axis.x < 0;
        }
    }


    public void PlayerDie()
    {
        //Time.timeScale = 0;
        SceneManager.LoadScene(GameOver);
    }
}