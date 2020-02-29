using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaEstadisticas : MonoBehaviour
{

    public GameObject pantalla1, pantalla2;

    public void pulsar()
    {
        pantalla1.SetActive(true);
        pantalla2.SetActive(false);
    }

}
