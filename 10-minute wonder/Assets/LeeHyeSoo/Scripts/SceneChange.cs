using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoToLobbyButton() //로비로 이동
    {
        Debug.Log("로비로 이동");
        SceneManager.LoadScene("Lobby");  //로비씬 이름
    }

    public void GameStartButton() //게임 플레이로 이동
    {
        Debug.Log("게임 바로 시작");
        SceneManager.LoadScene("SampleScene");  //게임플레이 씬 이름
    }

    public void ReturnToStartScene() //게임 시작씬으로 이동
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GameExit() //게임 종료 (유니티에서는 변화가 없지만 빌드하면 적용됩니다)
    {
        Debug.Log("게임을 완전히 종료하였습니다");
        Application.Quit();

    }
}
