using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botton : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject namePanel;
    public GameObject selectPanel;

    public void Start()
    {
        startPanel.SetActive(true);
        namePanel.SetActive(false);
        selectPanel.SetActive(false);
    }


    public void CambiarPanel00()
    {
        startPanel.SetActive(false);
        namePanel.SetActive(true);
    }

    public void CambiarPanel01()
    {
        namePanel.SetActive(false);
        selectPanel.SetActive(true);
    }

    public void ChangeSceneFacil()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeSceneMedio()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeSceneDificl()
    {
        SceneManager.LoadScene(3);
    }
}
