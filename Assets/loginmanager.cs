using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loginmanager : MonoBehaviour
{
    public InputField input;
    public string contra = "juan";
    

    public void check()
    {
        if (input.text == contra)
        {
            Debug.Log("acces si");
        }
        else
        {
            Debug.Log("acces no");
        }
    }
}
