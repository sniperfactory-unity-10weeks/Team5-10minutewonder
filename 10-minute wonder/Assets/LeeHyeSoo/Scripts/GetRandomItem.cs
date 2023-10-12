using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomItem : MonoBehaviour
{
    
    public List<Item> items;
    public List<Item> RandomItems;

    public GameObject itemLevelUpWindow;


    private void Update()
    {
        if(itemLevelUpWindow.activeSelf == true)
        {
            for(int i = 0; i < items.Count; i++) 
            {
                int Selectitem = Random.Range(0, items.Count);
                
            }
            
        }
    }


}
