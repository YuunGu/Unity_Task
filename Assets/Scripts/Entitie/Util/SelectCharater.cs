using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharater : MonoBehaviour
{
    public Image characterImage;
    public Image selectCharacterImage;

    public void Select()
    {
        selectCharacterImage.sprite = characterImage.sprite;
    }
}
