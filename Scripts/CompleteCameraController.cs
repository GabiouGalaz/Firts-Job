using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Data: 02/10

public class CompleteCameraController : MonoBehaviour
{//Variável pública para armazenar uma referência ao GameObject do player

    //Variável privada para armazenar a distância de deslocamento entre o player e a câmera.
    private Vector3 offset;        


    void Start()
    {
        //Calcule e armazene o valor do deslocamento, obtendo a distância entre a posição do jogador e a posição da câmera.
        offset = transform.position - player.transform.position;
    }

    
    void LateUpdate()
    {
        // Defina a posição da transform da câmera como igual à do player, mas compensada pela distância calculada da compensação.
        transform.position = player.transform.position + offset;
    }
}
