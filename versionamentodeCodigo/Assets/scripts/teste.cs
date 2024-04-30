using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Variveis e tipos de dados
        int pontos = 10;
        float peso = 61.8F;
        double medida = 9.99999999999;
        bool ativado = false;
        string saudacao = "Olá, tudo bem?";

        Debug.Log("Inteiro: " + pontos);
        Debug.Log("peso: " + peso);
        Debug.Log("medida: " + medida);
        Debug.Log("Booleana: " + ativado);
        Debug.Log("String: " + saudacao);
       

        //Operadores aritiméticos
        int soma = 2 + 2;
        int subtracao = 10 - 2;
        int multiplicacao = 2 * 3;
        float divisao = 10f / 3f;
        int resto = 10 % 3;

        Debug.Log("soma: " + soma);
        Debug.Log("subtracao: " + subtracao);
        Debug.Log("multiplicacao: " + multiplicacao);
        Debug.Log("divisao: " + divisao);
        Debug.Log("resto: " + resto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
