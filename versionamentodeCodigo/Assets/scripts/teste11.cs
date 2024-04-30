using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        // Indices ( posiçoes ) do Array
        //                 0  1  2  3  4   5  6  7  
        int[] numbers = {1, 2, 3, 4, 5, 89, 74, 58};
        Debug.Log(numbers);
        Debug.Log(numbers[3]);
        Debug.Log(numbers[6]);

        float[] grades = { 9.2f, 5.5f, 7.8f, 9.4f, 9.8f };
        foreach (float grade in grades)
        {
            Debug.Log(grade);
        }
        // 0 1 2 3 4 
        int[] values = new int[5];
        //values[0] = 3;
        //values[1] = 4;

        //Debug.Log(values[0]);

        for (int i = 0; i < values.Length; i++)
        {
            numbers[i] = i;
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
