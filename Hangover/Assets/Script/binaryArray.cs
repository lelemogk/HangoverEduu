using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class binaryArray : MonoBehaviour
{

    #region Singleton

    // Declara uma inst�ncia est�tica da classe 
    public static binaryArray instance;

    // M�todo chamado quando o script � inicializado
    private void Awake()
    {
        bits = new BitArray(initialBools);
        // Verifica se a inst�ncia � nula
        if (instance == null)
        {
            instance = this; // Define a inst�ncia para este objeto
            DontDestroyOnLoad(gameObject); // N�o destr�i o objeto ao carregar uma nova cena
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destroi o objeto se j� houver uma inst�ncia existente
        }
    }

    #endregion

    [SerializeField] public int width = 1;
    [SerializeField] public int size = 1;
    [SerializeField] private bool[] initialBools;

    private BitArray bits;

    public bool[] GetInitialBools()
    {
        return initialBools;
    }
}