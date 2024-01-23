using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject[] characters;
    public GameObject character;

    [SerializeField] TextMeshProUGUI nameTxt;

    private void Awake()
    {
        SetCharacter();
        ShowName();
    }

    public void SetCharacter()
    {
        character = characters[GameManager.I.characterNum];
        OffCharacters();
    }

    public void SetName(TMP_InputField nameInput)
    {
        if (!(nameInput.text.Length > 1 && nameInput.text.Length < 6)) return;

        GameManager.I.name = nameInput.text;
        nameInput.text = "";
        ShowName();
    }

    private void OffCharacters()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        character.SetActive(true);
    }

    private void ShowName()
    {
        nameTxt.text = GameManager.I.name;
    }

}
