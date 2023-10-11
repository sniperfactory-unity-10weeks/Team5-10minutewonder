using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseStats : MonoBehaviour
{
    public GameObject[] stat;
    public GameObject selectStat;

    private void Start()
    {
        selectStat = stat[0];
    }

    public void StatRightArrow()
    {
        Debug.Log("½ºÅÝ°­È­ ¿À¸¥ÂÊ ¹öÆ°");
        if (selectStat == stat[0])
        {
            selectStat = stat[1];
        }
        else if (selectStat == stat[1])
        {
            selectStat = stat[2];
        }
        else if (selectStat == stat[2])
        {
            selectStat = stat[3];
        }
        else if (selectStat == stat[3])
        {
            selectStat = stat[4];
        }
        else if (selectStat == stat[4])
        {
            selectStat = stat[5];
        }
        else if (selectStat == stat[5])
        {
            selectStat = stat[0];
        }
    }

    public void StatLeftArrow()
    {
        Debug.Log("¸Ê ¿ÞÂÊ ¹öÆ°");
        if (selectStat == stat[0])
        {
            selectStat = stat[5];
        }
        else if (selectStat == stat[5])
        {
            selectStat = stat[4];
        }
        else if (selectStat == stat[4])
        {
            selectStat = stat[3];
        }
        else if (selectStat == stat[3])
        {
            selectStat = stat[2];
        }
        else if (selectStat == stat[2])
        {
            selectStat = stat[1];
        }
        else if (selectStat == stat[1])
        {
            selectStat = stat[0];
        }
    }

    private void Update()
    {
        if (selectStat == stat[0])
        {
            stat[0].SetActive(true);
            stat[1].SetActive(false);
            stat[2].SetActive(false);
            stat[3].SetActive(false);
            stat[4].SetActive(false);
            stat[5].SetActive(false);
        }
        else if (selectStat == stat[1])
        {
            stat[0].SetActive(false);
            stat[1].SetActive(true);
            stat[2].SetActive(false);
            stat[3].SetActive(false);
            stat[4].SetActive(false);
            stat[5].SetActive(false);
        }
        else if (selectStat == stat[2])
        {
            stat[0].SetActive(false);
            stat[1].SetActive(false);
            stat[2].SetActive(true);
            stat[3].SetActive(false);
            stat[4].SetActive(false);
            stat[5].SetActive(false);
        }
        else if (selectStat == stat[3])
        {
            stat[0].SetActive(false);
            stat[1].SetActive(false);
            stat[2].SetActive(false);
            stat[3].SetActive(true);
            stat[4].SetActive(false);
            stat[5].SetActive(false);
        }
        else if (selectStat == stat[4])
        {
            stat[0].SetActive(false);
            stat[1].SetActive(false);
            stat[2].SetActive(false);
            stat[3].SetActive(false);
            stat[4].SetActive(true);
            stat[5].SetActive(false);
        }
        else if (selectStat == stat[5])
        {
            stat[0].SetActive(false);
            stat[1].SetActive(false);
            stat[2].SetActive(false);
            stat[3].SetActive(false);
            stat[4].SetActive(false);
            stat[5].SetActive(true);
        }
    }
}
