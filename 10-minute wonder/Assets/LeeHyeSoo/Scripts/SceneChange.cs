using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoToLobbyButton()
    {
        Debug.Log("�κ�� �̵�");
        SceneManager.LoadScene("Lobby");  //�κ�� �̸�
    }

    public void GameStartButton()
    {
        Debug.Log("���� �ٷ� ����");
        SceneManager.LoadScene("InGame");  //�����÷��� �� �̸�
    }

    public void ReturnToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GameExit()
    {
        Debug.Log("������ ������ �����Ͽ����ϴ�");
        Application.Quit();

    }
}
