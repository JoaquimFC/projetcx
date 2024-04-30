using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 5;

        switch (number)
        {
            case 1:
                Debug.Log("Numero 1");
                break;
            case 2:
                Debug.Log("Numero 2");
                break;
            case 3:
                Debug.Log("Numero 3");
                break;
            case 4:
                Debug.Log("Numero 4");
                break;
            default:
                Debug.Log("Nenhuma das opções");
                break; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
