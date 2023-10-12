using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, Drops
{
    public void Use(GameObject target)
    {
        
        Destroy(gameObject);
    }
}