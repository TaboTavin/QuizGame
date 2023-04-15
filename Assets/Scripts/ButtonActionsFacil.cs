using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActionsFacil : MonoBehaviour
{
    // PlayerPrefs.SetInt()
    // PlayerPrefs.SetFloat()
    // PlayerPrefs.SetString()

    public GameObject[] objectosPanels;
    public GameObject pregunta00;
    public GameObject pregunta01;
    public GameObject FinalPanel;

    public GameObject respuesta00;
    public GameObject respuesta01;
    public GameObject respuesta02;
    public GameObject respuesta03;

    public GameObject hintButton;
    int myScore;
    private void Start()
    {
        myScore = PlayerPrefs.GetInt("MyScore");

        FinalPanel.SetActive(false);

        for(int i=0; i<objectosPanels.Length; i++)
        {
            objectosPanels[i].SetActive(false);
        }

        objectosPanels = new GameObject[2]; //Cantidad de Preguntas

        // Asignar los Panels al Array
        objectosPanels[0] = pregunta00;
        objectosPanels[1] = pregunta01;

        PreguntaRandom();

        //PlayerPrefs Guardar el valor Int en PlayerPrefs
        PlayerPrefs.SetInt("MyScore", myScore);
        PlayerPrefs.Save();

        // Consultar/Recuperar valor entero de PlayerPrefs
        int newIntScore = PlayerPrefs.GetInt("MyScore");
        Debug.Log("New Score: " + newIntScore);

    }

    void PreguntaRandom()
    {
        int indiceAleatorio = Random.Range(0, objectosPanels.Length);
        GameObject objetoAleatorio = objectosPanels[indiceAleatorio];
        objetoAleatorio.SetActive(true);
    }

    public void HintButtonAction()
    {
        // Respuesta00 = Correcta
        // Respuesta 01 - 03 = Incorrectas

        respuesta01.SetActive(false);
        respuesta03.SetActive(false);

        hintButton.SetActive(false);
    }

    void DesactivarHint()
    {
        hintButton.SetActive(false);
    }


    public void RespuestaCorrecta()
    {
        myScore += 100;
        PlayerPrefs.SetInt("MyScore", myScore);
        PlayerPrefs.Save();

        ShowScore();
    }

    public void ShowScore()
    {
        int newIntScore = PlayerPrefs.GetInt("MyScore");
        Debug.Log("New Score: " + newIntScore);
    }

    private void Update()
    {
        if(myScore == 300)
        {
            hintButton.SetActive(true);
        }
    }

}
