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
    public GameObject name;
    public Button checkBtn;

    private void Update()
    {
        UserNameCheck();
    }

    private void UserNameCheck()
    {
        if (nameField.text.Length <= 2 || nameField.text.Length > 8)
        {
            checkBtn.image.color = Color.white;
        }
        else
        {
            checkBtn.image.color = Color.green;
        }
    }

    public void ChangeName()
    {
        if (checkBtn.image.color == Color.green)
        {
            userName.text = nameField.text;
            nameMenu.SetActive(false);
            name.SetActive(true);
            Time.timeScale = 1.0f;
        }
    }
}
