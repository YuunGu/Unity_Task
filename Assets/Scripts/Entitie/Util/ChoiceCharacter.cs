using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject Character1;
    [SerializeField]
    private GameObject Character2;
    [SerializeField]
    private GameObject characterMenu;
    [SerializeField]
    private GameObject name;



    public void CloseBtn()
    {
        Character1.SetActive(false);
        Character2.SetActive(true);
        characterMenu.SetActive(false);
        name.SetActive(true);
    }
}
