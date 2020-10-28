using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Openmenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject buttonA; 
    public void OpenPanel()
    {
        if(Panel.activeSelf == false)
        {
            Panel.SetActive(true);
            Vector3 pos = buttonA.transform.position;
            pos.y += 320f;
            buttonA.transform.position = pos;
        }
        else 
        {
            Panel.SetActive(false);
            Vector3 pos = buttonA.transform.position;
            pos.y -= 320f;
            buttonA.transform.position = pos;
        }
    }
}

