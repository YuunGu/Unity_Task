using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameNameChanger : MonoBehaviour
{
    [SerializeField]
    private InputField nameField;
    [SerializeField]
    private Text userName;
    public GameObject nameMenu;


    public void ChangeName()
    {
        userName.text = nameField.text;
    }
}
