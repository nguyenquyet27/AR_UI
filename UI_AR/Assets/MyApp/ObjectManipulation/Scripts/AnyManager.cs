using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyManager : MonoBehaviour
{
    public static AnyManager anyManager;
    bool gamestart;
    void Awake()
    {
        if (!gamestart)
        {
            anyManager = this;
            SceneManager.LoadSceneAsync(1,LoadSceneMode.Additive);
            gamestart = true;
        }
    }
}
