using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string[] Scenename;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void GoToLobbyButton() //�κ�� �̵�
    {
        Debug.Log("�κ�� �̵�");
        SceneManager.LoadScene("Lobby");  //�κ�� �̸�
    }

    public void GameStartButton() //���� �÷��̷� �̵�
    {
        Debug.Log("���� �ٷ� ����");
        Time.timeScale = 1;
        GameManager.instance.player.PlayerHP = PlayerPrefs.GetFloat("PlayerHP");
        GameManager.instance.player.recoverHP = PlayerPrefs.GetFloat("RecoverHP");
        GameManager.instance.player.AttackDamage = PlayerPrefs.GetFloat("AttackDamage");
        GameManager.instance.player.AttackSpeed = PlayerPrefs.GetFloat("AttackSpeed");
        GameManager.instance.player.PlayerSpeed = PlayerPrefs.GetFloat("PlayerSpeed");
        GameManager.instance.player.getGold = PlayerPrefs.GetInt("Gold");

        GameManager.instance.player.currentHp = PlayerPrefs.GetFloat("PlayerHP");

        SceneManager.LoadScene("InGameNew");  //�����÷��� �� �̸�
    }

    public void ReturnToStartScene() //���� ���۾����� �̵�
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GameExit() //���� ���� (����Ƽ������ ��ȭ�� ������ �����ϸ� ����˴ϴ�)
    {
        Debug.Log("������ ������ �����Ͽ����ϴ�");
        Application.Quit();

    }
}
