using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayScore : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public static int score; 
   
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = score.ToString();
    }
}
