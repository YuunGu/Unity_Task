using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    [SerializeField]
    private GameObject gameobject;
    [SerializeField]
    private GameObject gameobject2;



    public void CloseBtn()
    {
        gameobject.SetActive(false);
        gameobject2.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
