using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator[] pilares;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void leftActivate()
    {
        pilares[0].enabled = true;
    }
}
