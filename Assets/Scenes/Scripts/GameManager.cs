using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else { 
            _instance = this;
        }
    }
    #endregion

    public bool IsGameStarted { get; set; }

    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }
}
