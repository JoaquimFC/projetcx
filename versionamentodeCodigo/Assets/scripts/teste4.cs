using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = -10;

        if (number > 0 )
        {
            Debug.Log("o numero � maior que zero.");
        }
        else if (number == 0)
        {
            Debug.Log("o n�mero n�o � maior que zero");
        }
        else
        {
            Debug.Log("o numero n�o � maior que zero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
