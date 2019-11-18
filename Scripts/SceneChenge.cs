using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Data:03/10

public class SceneChenge : MonoBehaviour
{
    // Método que recebe um inteiro e carrega uma cena.
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
