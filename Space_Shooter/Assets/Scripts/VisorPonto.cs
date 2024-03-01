using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisorPonto : MonoBehaviour
{
    private GameControlador GC;
    public TMP_Text texto;
    private void Start()
    {
        texto = GetComponent<TMP_Text>();
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControlador>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "PONTOS: "+GC.MostrarPontos().ToString();
    }
}
