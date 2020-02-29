using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaStatsClose : MonoBehaviour
{
    public GameObject pantalla1, pantalla2;

    public void pulsar()
    {
        pantalla1.SetActive(false);
        pantalla2.SetActive(true);
    }

}
