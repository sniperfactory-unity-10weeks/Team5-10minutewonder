using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void GoToLobbyButton()
    {
        Debug.Log("�κ�� �̵�");
        //SceneManager.LoadScene("");  //�κ�� �̸�
    }

    public void GameStartButton()
    {
        Debug.Log("���� �ٷ� ����");
        //SceneManager.LoadScene("");  //�����÷��� �� �̸�
    }

    

    public void GameExit()
    {
        Application.Quit();
        Debug.Log("������ ������ �����Ͽ����ϴ�");
    }
}
