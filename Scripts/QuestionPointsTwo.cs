using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPointsTwo : MonoBehaviour
{
    // Recebe os pontos que serão adicionados
    [Range(0f, 10f)]
    public int addPoints;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //// Adiciona os pontos definidos na minha pontuação.
        //if (Input.GetMouseButtonDown(0))
        //    GameController.myPointsTwo += addPoints;
    }
    public void AddPoints()
    {
        Debug.Log("myPointsTwo " + GameController.myPointsTwo);
        GameController.myPointsTwo += addPoints;
        Debug.Log("myPointsTwo " + GameController.myPointsTwo);
    }
}
