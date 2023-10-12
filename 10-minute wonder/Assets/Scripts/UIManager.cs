using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameManager gameManager;

    public GameObject PauseCanvas; //일시정지 화면시 띄우는 Canvas
    public GameObject PlayCanvas; //플레이 화면시 띄우는 Canvas

    public Text Damage; //공격력
    public Text AttackSpeed; //공격속도
    public Text MoveSpeed; //이동속도
    public Text Health; //체력
    public Text HealthRcover; //회복력
    public Text Gold; //재화
    public Text PlayGold; //재화(플레이창)


    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        /*gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();*/

        PlayCanvas.gameObject.SetActive(true); // 기본 플레이 화면에서는 PlayUI만 볼 수 있게
        PauseCanvas.gameObject.SetActive(false); // 상태창 UI는 숨김

        Button pauseButton = FindObjectOfType<Button>(); //해당 Button
        pauseButton.onClick.AddListener(TogglePause); //할당
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) /*|| Input.GetButtonDown("PauseButton")*/) // PauseButton을 누르거나 ESC를 누르면 일시정지
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused) //isPaused 상태면
        {
            Time.timeScale = 0f; //게임 일시정지
        }
        else //아니면
        {
            Time.timeScale = 1f; //게임 재개
        }

        if (PauseCanvas != null) //PauseCanvas를 활성화 또는 비활성화
        {
            PauseCanvas.SetActive(isPaused);
        }

        if (PlayCanvas != null) //PlayCanvas를 활성화 또는 비활성화
        {
            PlayCanvas.SetActive(!isPaused);
        }

    }
    void PauseStatus()
    {
        //캐릭터 능력치 현황 상태창에 표기
        Damage.text = gameManager.attckPower.ToString();
        AttackSpeed.text = gameManager.attackCoolTime.ToString();
        MoveSpeed.text = gameManager.moveSpeed.ToString();
        Health.text = gameManager.hp.ToString();
        HealthRcover.text = gameManager.recover.ToString();
        Gold.text = PlayGold.text = gameManager.gold.ToString();
    }

}
