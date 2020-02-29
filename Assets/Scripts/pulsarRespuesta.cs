using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsarRespuesta : MonoBehaviour
{
    public GameObject respuesta1, respuesta2, respuesta3, respuesta4, respuesta5, respuesta6, respuesta7, results;

    public void OnMouseUpAsButton()
    {
        respuesta1.SetActive(false);
        respuesta2.SetActive(false);
        respuesta3.SetActive(false);
        respuesta4.SetActive(false);
        respuesta5.SetActive(false);
        respuesta6.SetActive(false);
        respuesta7.SetActive(false);

        results.SetActive(true);
        gameObject.SetActive(true);
    }
}
