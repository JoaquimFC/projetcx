using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float velocidade = 5f;
    public float Manainicial = 100f;
    public float taxaDeDecrementoMana = 1f;
    public float taxaRecuperaMana = 1f;
    public float manaAtual;
    public Slider sliderMana;
    private Rigidbody2D rb;
    bool isWalking = false;
    public Animator playerAnimator;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manaAtual = Manainicial;
        AtualizarSliderMana();
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        isWalking = eixoX != 0 || eixoY != 0;
        rb.velocity = new Vector2(eixoX, eixoY);
        //Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");


        if (eixoX != 0 || eixoY != 0)
        {
            manaAtual -= taxaDeDecrementoMana * Time.deltaTime;
            if (manaAtual <=0 )
            {
                manaAtual = 0;
                SceneManager.LoadScene(2);
            }
            playerAnimator.SetFloat("eixoX", eixoX);
            playerAnimator.SetFloat("eixoY", eixoY);

            AtualizarSliderMana();
        }
        playerAnimator.SetBool("isWalking", isWalking);
        if (Input.GetButtonDown("Fire1"))
        {
            playerAnimator.SetTrigger("attack");
        }
    }
    void AtualizarSliderMana()
    {
        sliderMana.value = manaAtual / Manainicial;
  }
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Recover"))
        {
            Debug.Log("consegui colidir ...");
            StartCoroutine(RecuperaMana());
        }
       
    }

    IEnumerator RecuperaMana()
    {
        while (manaAtual < Manainicial)
        {
            manaAtual += taxaRecuperaMana * Time.deltaTime;
            AtualizarSliderMana();
            yield return null;
        }
    }
}

