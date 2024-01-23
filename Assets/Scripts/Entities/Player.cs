using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
