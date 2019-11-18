using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Inserido

public class SelectOnInput : MonoBehaviour
{
    // Recebendo o Event System do Canvas.
    public EventSystem myEventSystem;

    // Recebe o botão que vai receber o foco.
    public GameObject mySelectedObject;

    // Armazena se o botão está selecionado.
    private bool myButtonSelected;

    void Update()
    {
        // Se o input "Vertical" for diferente de 0 e ...
        // o botão estiver selecionado...
        if (Input.GetAxisRaw("Vertical") != 0 &&
            myButtonSelected == false)
        {
            // Seleciona o GameObject passado no parametro.
            myEventSystem.SetSelectedGameObject(mySelectedObject);

            // Torna o botão como selecionado.
            myButtonSelected = true;
        }
    }

    // Quando o Gameobject não estiver selecionado...
    private void OnDisable()
    {
        // Torna o botão como não selecionado.
        myButtonSelected = false;
    }
}
