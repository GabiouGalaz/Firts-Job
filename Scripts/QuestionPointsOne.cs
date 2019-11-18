using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPointsOne : MonoBehaviour
{
    // Recebe os pontos que serão adicionados
    [Range(0f, 10f)]
    public int addPoints;

    void Start()
    {
        
    }


    void Update()
    {
        // Adiciona os pontos definidos na minha pontuação.
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log(gameObject.name);

        //}
    }

    public void AddPoints()
    {
        Debug.Log("myPointsOne " + GameController.myPointsOne);
        GameController.myPointsOne += addPoints;
        Debug.Log("myPointsOne " + GameController.myPointsOne);
    }
}
