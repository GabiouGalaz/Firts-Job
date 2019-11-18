using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Inserido para usar "Text"!

public class GameController : MonoBehaviour
{
    // Armazenar a pontuação do jogador. ---Recrutador 1
    // static permite que eu acesse esse atributo de outra classe.
    public static int myPointsOne;

    // Armazenar a pontuação do jogador. ---Recrutador 2
    public static int myPointsTwo;

    // Armazenar a pontuação do jogador. ----Recrutador 3
    public static int myPointsThree;  

    
    // Armazena o campo de texto responsável pelos meus pontos. ----Recrutador 1
    public Text myTextPointsOne;

    // Armazena o campo de texto responsável pelos meus pontos. ----Recrutador 2
    public Text myTextPointsTwo;

    // Armazena o campo de texto responsável pelos meus pontos. ----Recrutador 3
    public Text myTextPointsThree;


    // Armazena o campo de texto antes do inicio. ---Recrutador 1
    private string textPointsOne;

    // Armazena o campo de texto antes do inicio. ---Recrutador 2
    private string textPointsTwo;

    // Armazena o campo de texto antes do inicio. ---Recrutador 3
    private string textPointsThree;

    void Start()
    {
        // Recebe o campo text do "myTextPoints". ---Recrutador 1
        textPointsOne = myTextPointsOne.text;

        // Recebe o campo text do "myTextPoints". ---Recrutador 2
        textPointsTwo = myTextPointsTwo.text;

        // Recebe o campo text do "myTextPoints". ---Recrutador 3
        textPointsThree = myTextPointsThree.text;
    }

   
    void Update()
    {
        // Campo Text Points recebe o valor de points.  ---Recrutador 1
        myTextPointsOne.text = textPointsOne + myPointsOne.ToString();

        // Campo Text Points recebe o valor de points.  ---Recrutador 2
        myTextPointsTwo.text = textPointsTwo + myPointsTwo.ToString();

        // Campo Text Points recebe o valor de points.  ---Recrutador 3
        myTextPointsThree.text = textPointsThree + myPointsThree.ToString();
    }
}
