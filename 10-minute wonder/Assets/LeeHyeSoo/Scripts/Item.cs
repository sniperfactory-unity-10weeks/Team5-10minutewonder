using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;

    [TextArea(3, 5)]
    public string itemMemo;

    
}
