﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDaño : MonoBehaviour
{

    public LogicaBarraDeVida logicaBarraDeVidaJugador;
    //public LogicaBarraDeVida logicaBarraDeVidaEnemigo;

    public float daño = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            logicaBarraDeVidaJugador.vidaActual -= daño;
        }


    }
}
