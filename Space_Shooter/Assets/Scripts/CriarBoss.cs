using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarBoss : MonoBehaviour
{

    private EnemySpawner ES;
    // Start is called before the first frame update
    void Start()
    {
        ES = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBoss()
    {
        ES.AtivaBoss();


    }

}
