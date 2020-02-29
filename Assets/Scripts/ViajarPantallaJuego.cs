using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ViajarPantallaJuego : MonoBehaviour
{
    public InputField inputField1, inputField2, inputField3, inputField4, inputField5, inputField6,
        inputField7, inputField8;
    int numJugadores = 0;


    private void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Viajar()
    {
        if (inputField1.text != "")
        {
            PlayerPrefs.SetString("player1", inputField1.text);
            numJugadores++;
        }
        if (inputField2.text != "")
        {
            PlayerPrefs.SetString("player2", inputField2.text);
            numJugadores++;
        }
        if (inputField3.text != "")
        {
            PlayerPrefs.SetString("player3", inputField3.text);
            numJugadores++;
        }
        if (inputField4.text != "")
        {
            PlayerPrefs.SetString("player4", inputField4.text);
            numJugadores++;
        }
        if (inputField5.text != "")
        {
            PlayerPrefs.SetString("player5", inputField5.text);
            numJugadores++;
        }
        if (inputField6.text != "")
        {
            PlayerPrefs.SetString("player6", inputField6.text);
            numJugadores++;
        }
        if (inputField7.text != "")
        {
            PlayerPrefs.SetString("player7", inputField7.text);
            numJugadores++;
        }
        if (inputField8.text != "")
        {
            PlayerPrefs.SetString("player8", inputField8.text);
            numJugadores++;
        }
        PlayerPrefs.SetInt("numJugadores", numJugadores);
        PlayerPrefs.SetInt("jugadorActual", 2);
        PlayerPrefs.SetInt("jugadorPregunta", 0);
        SceneManager.LoadScene("PantallaJuego");
    }
}
