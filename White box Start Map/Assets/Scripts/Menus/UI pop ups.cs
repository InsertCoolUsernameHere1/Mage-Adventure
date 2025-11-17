using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class talkToUI : MonoBehaviour
{

    public Text propToUI;
    public string message;

    //	Display message from public variable to UI text label on mouse click...
    void OnMouseDown()
    {
        propToUI.text = message;
    }
}