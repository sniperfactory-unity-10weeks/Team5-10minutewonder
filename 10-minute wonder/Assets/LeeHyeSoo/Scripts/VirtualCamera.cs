using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VirtualCamera : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera cinemachine;

    public static VirtualCamera instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cinemachine = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    private void OnEnable()
    {
        //cinemachine.Follow = GameManager.instance.player.transform;
    }
}
