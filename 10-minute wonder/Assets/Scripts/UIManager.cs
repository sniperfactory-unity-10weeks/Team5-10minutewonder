using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameManager gameManager;

    public GameObject PauseCanvas; //�Ͻ����� ȭ��� ���� Canvas
    public GameObject PlayCanvas; //�÷��� ȭ��� ���� Canvas

    public Text Damage; //���ݷ�
    public Text AttackSpeed; //���ݼӵ�
    public Text MoveSpeed; //�̵��ӵ�
    public Text Health; //ü��
    public Text HealthRcover; //ȸ����
    public Text Gold; //��ȭ
    public Text PlayGold; //��ȭ(�÷���â)


    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        /*gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();*/

        PlayCanvas.gameObject.SetActive(true); // �⺻ �÷��� ȭ�鿡���� PlayUI�� �� �� �ְ�
        PauseCanvas.gameObject.SetActive(false); // ����â UI�� ����

        Button pauseButton = FindObjectOfType<Button>(); //�ش� Button
        pauseButton.onClick.AddListener(TogglePause); //�Ҵ�
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) /*|| Input.GetButtonDown("PauseButton")*/) // PauseButton�� �����ų� ESC�� ������ �Ͻ�����
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused) //isPaused ���¸�
        {
            Time.timeScale = 0f; //���� �Ͻ�����
        }
        else //�ƴϸ�
        {
            Time.timeScale = 1f; //���� �簳
        }

        if (PauseCanvas != null) //PauseCanvas�� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
        {
            PauseCanvas.SetActive(isPaused);
        }

        if (PlayCanvas != null) //PlayCanvas�� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
        {
            PlayCanvas.SetActive(!isPaused);
        }

    }
    void PauseStatus()
    {
        //ĳ���� �ɷ�ġ ��Ȳ ����â�� ǥ��
        Damage.text = gameManager.attckPower.ToString();
        AttackSpeed.text = gameManager.attackCoolTime.ToString();
        MoveSpeed.text = gameManager.moveSpeed.ToString();
        Health.text = gameManager.hp.ToString();
        HealthRcover.text = gameManager.recover.ToString();
        Gold.text = PlayGold.text = gameManager.gold.ToString();
    }

}
