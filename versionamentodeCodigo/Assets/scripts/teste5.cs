using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = -5;
        string messege = number > 0 ? "numero positivo" : "numero negativo";
        Debug.Log(messege);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
