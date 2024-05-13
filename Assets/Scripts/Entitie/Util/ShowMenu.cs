using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameobject;
    [SerializeField]
    private GameObject gameobject2;

    public void OpenBtn()
    {
        gameobject.SetActive(true);
        gameobject2.SetActive(false);
        if (gameobject.name == "Join")
        {
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0f;
        }
        
    }
}
