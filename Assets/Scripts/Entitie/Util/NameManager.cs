using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameManager : MonoBehaviour
{
    [SerializeField]
    private InputField nameField;
    [SerializeField]
    private Button button;
    [SerializeField]
    private string userName;
    GameManager gameManager;

    private void Update()
    {
        userName = nameField.text;
        UserNameCheck();
    }

    private void UserNameCheck()
    {
        if (userName.Length <= 2 || userName.Length > 8)
        {
            button.image.color = Color.white;
        }
        else
        {
            button.image.color = Color.green;
        }
    }

    

    public void Start()
    {
        if (button.image.color == Color.green)
        {
            gameManager.userName = userName;
            SceneManager.LoadScene("MainScene");            
        }
    }
}
