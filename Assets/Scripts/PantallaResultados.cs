using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PantallaResultados : MonoBehaviour
{
    public GameObject respuesta1, respuesta2, respuesta3, respuesta4, respuesta5, respuesta6,
        respuesta7, respuestaEscogida, jugadorPregunta, preguntaActual;
    int numJugadores, jugadorActualPregunta, posicion = 0, numAleatorio;
    bool activar = true;
    List<int> listNums = new List<int>();
    List<string> listJugadores = new List<string>();
    string[] respuestasJugadores = new string[8];

    void Start()
    {
        jugadorActualPregunta = PlayerPrefs.GetInt("jugadorPregunta");
        numJugadores = PlayerPrefs.GetInt("numJugadores");

        jugadorPregunta.GetComponent<Text>().text = PlayerPrefs.GetString("player" + jugadorActualPregunta);
        preguntaActual.GetComponent<Text>().text = PlayerPrefs.GetString("preguntaActual");


        for (int i = 1; i < numJugadores + 1; i++)
        {
            if (jugadorActualPregunta != i)
            {
                string jugador = "respuestaPlayer" + i;
                respuestasJugadores[posicion] = PlayerPrefs.GetString(jugador);
                listJugadores.Add(PlayerPrefs.GetString("player"+i));
                posicion++;
            }
        }

        respuesta1.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
        respuesta2.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
        if (numJugadores > 3)
        {
            respuesta3.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
            if (numJugadores > 4)
            {
                respuesta4.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
                if (numJugadores > 5)
                {
                    respuesta5.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
                    if (numJugadores > 6)
                    {
                        respuesta6.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
                        if (numJugadores > 7)
                        {
                            respuesta7.GetComponentInChildren<Text>().text = respuestasJugadores[NumRandom()];
                        }
                        else
                        {
                            respuesta7.SetActive(false);
                        }
                    }
                    else
                    {
                        respuesta6.SetActive(false);
                        respuesta7.SetActive(false);
                    }
                }
                else
                {
                    respuesta5.SetActive(false);
                    respuesta6.SetActive(false);
                    respuesta7.SetActive(false);
                }
            }
            else
            {
                respuesta4.SetActive(false);
                respuesta5.SetActive(false);
                respuesta6.SetActive(false);
                respuesta7.SetActive(false);
            }
        }
        else
        {
            respuesta3.SetActive(false);
            respuesta4.SetActive(false);
            respuesta5.SetActive(false);
            respuesta6.SetActive(false);
            respuesta7.SetActive(false);
        }
    }

    private void Update()
    {
        if ((respuesta1.activeSelf == false || respuesta2.activeSelf == false) && activar == true)
        {
            string nombreJugador = "";
            activar = false;
            respuestaEscogida.SetActive(true);
            
            if (respuesta1.activeSelf == true)
            {
                nombreJugador = listJugadores.ElementAt(listNums.ElementAt(0));
                respuestaEscogida.GetComponent<Text>().text = nombreJugador;
            }
            else
            {
                if (respuesta2.activeSelf == true)
                {
                    nombreJugador = listJugadores.ElementAt(listNums.ElementAt(1));
                    respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                }
                else
                {
                    if (respuesta3.activeSelf == true)
                    {
                        nombreJugador = listJugadores.ElementAt(listNums.ElementAt(2));
                        respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                    }
                    else
                    {
                        if (respuesta4.activeSelf == true)
                        {
                            nombreJugador = listJugadores.ElementAt(listNums.ElementAt(3));
                            respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                        }
                        else
                        {
                            if (respuesta5.activeSelf == true)
                            {
                                nombreJugador = listJugadores.ElementAt(listNums.ElementAt(4));
                                respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                            }
                            else
                            {
                                if (respuesta6.activeSelf == true)
                                {
                                    nombreJugador = listJugadores.ElementAt(listNums.ElementAt(5));
                                    respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                                }
                                else
                                {
                                    if (respuesta7.activeSelf == true)
                                    {
                                        nombreJugador = listJugadores.ElementAt(listNums.ElementAt(6));
                                        respuestaEscogida.GetComponent<Text>().text = nombreJugador;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            SumarPuntos(nombreJugador);
        }
    }


    int NumRandom()
    {
        do
        {
            numAleatorio = Random.Range(0, (numJugadores - 1) * 100);
            numAleatorio = (int)numAleatorio / 100;
        } while (listNums.Contains(numAleatorio));

        listNums.Add(numAleatorio);
        return numAleatorio;
    }
    
    void SumarPuntos(string nombre)
    {
        int puntos = PlayerPrefs.GetInt(nombre, 0);
        puntos++;
        PlayerPrefs.SetInt(nombre, puntos);
    }
}
