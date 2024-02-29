using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private string NomeDoLevelJogo;
    [SerializeField] private string NomeDoLevelJogo2;
    [SerializeField] private GameObject PainelMenuInical;

    public void Jogar()
    {
        SceneManager.LoadScene(NomeDoLevelJogo);
        SceneManager.LoadScene(NomeDoLevelJogo2);
    }

  
    


   
}
