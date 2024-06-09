using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void Interact(GameObject src)//src как сокращение от source
    {
        transform.SetParent(src.transform,true);       
    }

}