using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPointsThree : MonoBehaviour
{
    // Recebe os pontos que serão adicionados
    [Range(0f, 10f)]
    public int addPoints;

    void Start()
    {

    }


    void Update()
    {
        //    // Adiciona os pontos definidos na minha pontuação.
        //if (Input.GetMouseButtonDown(0))
        //    GameController.myPointsThree += addPoints;

    }
    public void AddPoints()
    {
        Debug.Log("myPointsThree " + GameController.myPointsThree);
        GameController.myPointsThree += addPoints;
        Debug.Log("myPointsThree " + GameController.myPointsThree);
    }
}
