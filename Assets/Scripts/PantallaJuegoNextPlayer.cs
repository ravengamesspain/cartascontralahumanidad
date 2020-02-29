using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PantallaJuegoNextPlayer : MonoBehaviour
{
    int numJugadores, jugadorAleatorio, jugadorActual, jugadorActualPregunta;
    public Text jugadorPregunta, jugadorResponde, pregunta;
    public InputField inputField;


    public void SiguienteJugador()
    {
        numJugadores = PlayerPrefs.GetInt("numJugadores");
        jugadorActualPregunta = PlayerPrefs.GetInt("jugadorPregunta");
        jugadorActual = PlayerPrefs.GetInt("jugadorActual");

        jugadorActual++;
        if (jugadorActual == numJugadores + 1) jugadorActual = 1;
        NextPlayer();
    }

    void NextPlayer()
    {
        switch (jugadorActual)
        {
            case 1:
                GuardarLastPlayer();
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player1");
                break;
            case 2:
                PlayerPrefs.SetString("respuestaPlayer1", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player2");
                break;
            case 3:
                PlayerPrefs.SetString("respuestaPlayer2", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player3");
                break;
            case 4:
                PlayerPrefs.SetString("respuestaPlayer3", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player4");
                break;
            case 5:
                PlayerPrefs.SetString("respuestaPlayer4", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player5");
                break;
            case 6:
                PlayerPrefs.SetString("respuestaPlayer5", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player6");
                break;
            case 7:
                PlayerPrefs.SetString("respuestaPlayer6", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player7");
                break;
            case 8:
                PlayerPrefs.SetString("respuestaPlayer7", inputField.text);
                jugadorResponde.text = "Responde " + PlayerPrefs.GetString("player8");
                break;
        }
        inputField.text = "";
        PlayerPrefs.SetInt("jugadorActual", jugadorActual);

        if (jugadorActual == jugadorActualPregunta) SceneManager.LoadScene("PantallaResultados");
    }

    public void GuardarLastPlayer()
    {
        if (numJugadores == 2)
        {
            PlayerPrefs.SetString("respuestaPlayer2", inputField.text);
        }
        else
        {
            if (numJugadores == 3)
            {
                PlayerPrefs.SetString("respuestaPlayer3", inputField.text);
            }
            else
            {
                if (numJugadores == 4)
                {
                    PlayerPrefs.SetString("respuestaPlayer4", inputField.text);
                }
                else
                {
                    if (numJugadores == 5)
                    {
                        PlayerPrefs.SetString("respuestaPlayer5", inputField.text);
                    }
                    else
                    {
                        if (numJugadores == 6)
                        {
                            PlayerPrefs.SetString("respuestaPlayer6", inputField.text);
                        }
                        else
                        {
                            if (numJugadores == 7)
                            {
                                PlayerPrefs.SetString("respuestaPlayer7", inputField.text);
                            }
                            else
                            {
                                PlayerPrefs.SetString("respuestaPlayer8", inputField.text);
                            }
                        }
                    }
                }
            }
        }
    }
}
