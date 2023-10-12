using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoToLobbyButton() //�κ�� �̵�
    {
        Debug.Log("�κ�� �̵�");
        SceneManager.LoadScene("Lobby");  //�κ�� �̸�
    }

    public void GameStartButton() //���� �÷��̷� �̵�
    {
        Debug.Log("���� �ٷ� ����");
        SceneManager.LoadScene("SampleScene");  //�����÷��� �� �̸�
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
