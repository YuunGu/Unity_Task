using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text userName;
    public Data data;
    public GameObject charaterModel1;
    public GameObject charaterModel2;
    public GameObject charater;
    public GameObject NPCTalk;

    void Start()
    {
        if(data.charaterNumber == 0)
        {
            charaterModel2.SetActive(true);
            charaterModel1.SetActive(false);
        }else
        {
            charaterModel2.SetActive(false);
            charaterModel1.SetActive(true);
        }
        userName.text = data.userName;
    }

    
    void Update()
    {
        if ( charater.transform.position.y >= 20)
        {
            NPCTalk.SetActive(true);
        }else
        {
            NPCTalk.SetActive(false);
        }
    }
}
