using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data:15/10/2019
//Descrição: Para fazer o personagem se locomover.
public class PlayerController : MonoBehaviour
{
   //Aplica a velocidade de deslocamento do personagem,
   //no painel Inspector da Unity pode ser modificado.
   public float moveSpeed = 5f; 

    //Jogador com o rigidbody2D  
    public Rigidbody2D player2D;

    //Para colocar as animações
    public Animator animator;
    
    // Usando o vector2 para mexer somente nos eixos x e y.
    Vector2 movementPlayer;

    void Start()
    {
        //Armazenar os componentes do rigidbody2D
        player2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Movimentar o player com os input horizontal (a e d) ou as setas.
        movementPlayer.x = Input.GetAxisRaw("Horizontal");
        
        //Movimentar o player com os input vertical (w e s) ou as setas.
        movementPlayer.y = Input.GetAxisRaw("Vertical");

       //Ativar animação para seu deslocamento. 
        animator.SetFloat("Horizontal", movementPlayer.x);
        animator.SetFloat("Vertical", movementPlayer.y);
        
        //Ativar sua animação...
        animator.SetFloat("Speed", movementPlayer.sqrMagnitude);
    }

    //
    void FixedUpdate()
    {
       //Movimentando o player aplicando a velocidade em seu deslocamento.
        player2D.MovePosition(player2D.position + movementPlayer * moveSpeed * Time.fixedDeltaTime)
      
    }
}w55t
