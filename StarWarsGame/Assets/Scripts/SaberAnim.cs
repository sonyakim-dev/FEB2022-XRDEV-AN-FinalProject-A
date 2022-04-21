using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberAnim: MonoBehaviour
{
    public Animator bladeanim;
    private bool isEnabled = false;
    

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleBlade();
        }
    }

    private void ToggleBlade()
    {
        isEnabled = !isEnabled;
        bladeanim.SetBool("IsOn", isEnabled);
    }
}
