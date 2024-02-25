using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{
    public List<GameObject> MinhasEsferas;
    public GameObject Bola;
    public float meuTempo;

    private GameControlador GC;

    private void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControlador>();
    }

    void Update()
    {
        //CriarBola();
        if(GC.InformaEstado() == true)
        {
            CriarBolaDificil();
        }
        
    }

    void CriarBola()
    {
        meuTempo += Time.deltaTime;
        if (meuTempo > 1)
        {
            float posX = Random.Range(-2, 2.1f);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            int tipoEsfera = Random.Range(0, 4);
            GameObject Bol = Instantiate(MinhasEsferas[tipoEsfera], novaPos, Quaternion.identity);
            Destroy(Bol, 2f);
            meuTempo = 0;
        }
    }

    void CriarBolaDificil()
    {
        meuTempo += Time.deltaTime;
        if (meuTempo > 1)
        {
            float posX = Random.Range(-2, 2.1f);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            int esferaEscolhida = 0;
            int tipoEsfera = Random.Range(0, 101);
            if (tipoEsfera < 10)
            {
                esferaEscolhida = 4;
            }
            else if (tipoEsfera < 80)
            {
                esferaEscolhida = 0;
            }
            else if(tipoEsfera < 90)
            {
                esferaEscolhida = 1;
            }
            else if (tipoEsfera < 98)
            {
                esferaEscolhida = 2;
            }
            else
            {
                esferaEscolhida = 3;
            }
            GameObject Bol = Instantiate(MinhasEsferas[esferaEscolhida], novaPos, Quaternion.identity);
            Destroy(Bol, 2f);
            meuTempo = 0;
        }
    }
}
