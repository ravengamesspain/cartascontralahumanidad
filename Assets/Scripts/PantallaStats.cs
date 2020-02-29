using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaStats : MonoBehaviour
{
    public GameObject jugador1, jugador2, jugador3, jugador4, jugador5, jugador6,
        jugador7, jugador8, puntosJugador1, puntosJugador2, puntosJugador3, puntosJugador4, 
        puntosJugador5, puntosJugador6, puntosJugador7, puntosJugador8;
    int numJugadores;

    void Start()
    {
        numJugadores = PlayerPrefs.GetInt("numJugadores");

        jugador1.GetComponent<Text>().text = PlayerPrefs.GetString("player1");
        jugador2.GetComponent<Text>().text = PlayerPrefs.GetString("player2");
        jugador3.GetComponent<Text>().text = PlayerPrefs.GetString("player3");

        if (numJugadores > 3)
        {
            jugador4.SetActive(true);
            jugador4.GetComponent<Text>().text = PlayerPrefs.GetString("player4");
        }
        if (numJugadores > 4) 
        {
            jugador5.SetActive(true);
            jugador5.GetComponent<Text>().text = PlayerPrefs.GetString("player5");
        }
        if (numJugadores > 5)
        {
            jugador6.SetActive(true);
            jugador6.GetComponent<Text>().text = PlayerPrefs.GetString("player6");
        }
        if (numJugadores > 6)
        {
            jugador7.SetActive(true);
            jugador7.GetComponent<Text>().text = PlayerPrefs.GetString("player7");
        }
        if (numJugadores > 7)
        {
            jugador8.SetActive(true);
            jugador8.GetComponent<Text>().text = PlayerPrefs.GetString("player8");
        }

        puntosJugador1.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player1"), 0).ToString();
        puntosJugador2.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player2"), 0).ToString();
        puntosJugador3.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player3"), 0).ToString();
        if (numJugadores > 3)
        {
            puntosJugador4.SetActive(true);
            puntosJugador4.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player4"),0).ToString();
        }
        if (numJugadores > 4)
        {
            puntosJugador5.SetActive(true);
            puntosJugador5.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player5"), 0).ToString();
        }
        if (numJugadores > 5)
        {
            puntosJugador6.SetActive(true);
            puntosJugador6.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player6"), 0).ToString();
        }
        if (numJugadores > 6)
        {
            puntosJugador7.SetActive(true);
            puntosJugador7.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player7"), 0).ToString();
        }
        if (numJugadores > 7)
        {
            puntosJugador8.SetActive(true);
            puntosJugador8.GetComponent<Text>().text = PlayerPrefs.GetInt(PlayerPrefs.GetString("player8"), 0).ToString();
        }
    }

}
