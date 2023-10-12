using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    GameManager gameManager;
    

    public Text attckpowerText; //공격력 텍스트
    public Text attackCoolTimeText; //공격쿨타임 텍스트
    public Text hpText; //체력 텍스트
    public Text recoverText; //회복력(재생력) 텍스트
    public Text moveSpeedText; //이동속도 텍스트
    public Text goldText; //골드량 텍스트



    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find(name: "GameManager").GetComponent<GameManager>();
        


    }

    // Update is called once per frame
    void Update()
    {
        
        StatTextInLobby();
        
    }

    void StatTextInLobby()
    {
        attckpowerText.text = "공격력: " + gameManager.attckPower.ToString();
        attackCoolTimeText.text = "공격 쿨타임: " + gameManager.attackCoolTime.ToString();
        hpText.text = "HP: " + gameManager.hp.ToString();
        recoverText.text = "회복력: " + gameManager.recover.ToString();
        moveSpeedText.text = "이동속도: " + gameManager.moveSpeed.ToString();
        goldText.text = "골드량: " + gameManager.gold.ToString() + " G";
    }
}
