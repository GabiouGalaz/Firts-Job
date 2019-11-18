using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //Recebe o meu Audio Source
    public AudioSource myAudioSource;

    void Start()
    {
        //Recebe acesso a todos os atributos do componente.
        myAudioSource = GetComponent<AudioSource>();
        //Executa meu Audio Source a partir do início.
        myAudioSource.Play(0);
    }

    
    void Update()
    {
        
    }
}
