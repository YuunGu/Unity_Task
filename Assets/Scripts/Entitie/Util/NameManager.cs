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
    private Data data;

    [SerializeField]
    private Image image;

    public string userName = "";

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
            data.userName = userName;
        }
    }

    

    public void Start()
    {
        if (button.image.color == Color.green)
        {
            if(image.sprite.name == "necromancer_anim_f0")
            {
                data.charaterNumber = 0;
            }else
            {
                data.charaterNumber = 1;
            }
            SceneManager.LoadScene("MainScene");            
        }
    }
}
