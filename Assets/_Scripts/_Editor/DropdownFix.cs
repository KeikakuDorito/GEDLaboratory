using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFix : MonoBehaviour
{

    public string sortingLayer = "UI"; //Or what ever layer you want it to be

    public void OnDropdownClick()
    {
        Transform droplist = transform.Find("Dropdown");

        if (droplist != null)
        {
            droplist.GetComponent<Canvas>().sortingLayerName = sortingLayer;
        }
    }
}