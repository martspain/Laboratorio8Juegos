using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HousePropBehaviour : MonoBehaviour
{

    public GameObject text;

    private void OnMouseOver()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
        {
            if (text && hitInfo.distance <= 3.0f)
            {
                text.GetComponent<Text>().text = gameObject.tag;
            }
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
