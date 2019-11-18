using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Data: 30/10/2019
//Descrição: Contador de pontos e troca de questões após animação do recrutador.

public class teste : MonoBehaviour
{
    //Game Object para colocar os botões
    public GameObject myButton;

    //Animações troca
    private int animT = 0;

    //Contador de pontos 
    private int pointP;

    //Animação do Recrutador 
    public Animator myAnimator;

    //Contador de tempo.
    public float timeCounter;

    //Armazenar os pontos 


    void Start()
    {
        //Chamar animação inicial
        myAnimator = gameObject.GetComponent<Animator>();

    }


    void Update()
    {
        //Confirmar se trocou de painel

        //Antes de trocar, ativar animação
    }


    void AnimActivator()
    {
        switch (animT)
        {
            case (3):
                myAnimator.SetBool("Humor", true);
                break;
            case (2):
                myAnimator.SetBool("Humor", true);
                break;
            case (1):
                myAnimator.SetBool("Humor", true);
                break;
            default :
                myAnimator.SetBool("Humor", false);
                break;
        }

    }

    //void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    startTime = Time.time;
    //}

}
