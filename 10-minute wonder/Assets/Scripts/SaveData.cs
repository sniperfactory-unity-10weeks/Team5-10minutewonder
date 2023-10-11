using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : PlayerData
{
    // Start is called before the first frame update
    void Start()
    {
        Save(); // 게임이 시작할 때 초기 데이터를 저장함
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("PlayerHP", PlayerHP);
        PlayerPrefs.SetFloat("recoverHP", recoverHP);
        PlayerPrefs.SetFloat("AttackDamage", AttackDamage);
        PlayerPrefs.SetFloat("AttackSpeed", AttackSpeed);
        PlayerPrefs.SetFloat("PlayerSpeed", PlayerSpeed);
    }
}
