using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void GoToLobbyButton()
    {
        Debug.Log("�κ�� �̵�");
<<<<<<< HEAD
        SceneManager.LoadScene("Lobby");  //�κ�� �̸�
=======
        //SceneManager.LoadScene("");  //�κ�� �̸�
>>>>>>> origin/ssm
    }

    public void GameStartButton()
    {
        Debug.Log("���� �ٷ� ����");
<<<<<<< HEAD
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
        
=======
        //SceneManager.LoadScene("");  //�����÷��� �� �̸�
    }

    

    public void GameExit()
    {
        Application.Quit();
        Debug.Log("������ ������ �����Ͽ����ϴ�");
>>>>>>> origin/ssm
    }
}
