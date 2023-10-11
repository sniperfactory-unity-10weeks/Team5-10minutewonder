using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void GoToLobbyButton()
    {
        Debug.Log("로비로 이동");
        //SceneManager.LoadScene("");  //로비씬 이름
    }

    public void GameStartButton()
    {
        Debug.Log("게임 바로 시작");
        //SceneManager.LoadScene("");  //게임플레이 씬 이름
    }

    

    public void GameExit()
    {
        Application.Quit();
        Debug.Log("게임을 완전히 종료하였습니다");
    }
}
