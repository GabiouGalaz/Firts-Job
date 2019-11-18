using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data:15/10/2019
//Descrição: Para fazer o personagem se locomover.
public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f; 

    //Jogador com o rigidbody2D  
    public Rigidbody2D player2D;

    //Para colocar as animações
    public Animator animator;

    Vector2 movementPlayer;

    void Start()
    {
        //Armazenar os componentes do rigidbody2D
        player2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
        movementPlayer.x = Input.GetAxisRaw("Horizontal");
        movementPlayer.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movementPlayer.x);
        animator.SetFloat("Vertical", movementPlayer.y);
        animator.SetFloat("Speed", movementPlayer.sqrMagnitude);
    }

    //
    void FixedUpdate()
    {

        player2D.MovePosition(player2D.position + movementPlayer * moveSpeed * Time.fixedDeltaTime);


       
    }
}
