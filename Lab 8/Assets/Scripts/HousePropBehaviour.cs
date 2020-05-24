using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HousePropBehaviour : MonoBehaviour
{

    public GameObject text;

    private void OnMouseEnter()
    {
        if (text) 
        {
            text.GetComponent<Text>().text = gameObject.tag;
        }
    }

    private void OnMouseExit()
    {
        if (text)
        {
            text.GetComponent<Text>().text = "";
        }
    }

}
