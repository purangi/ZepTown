using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterCreate : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] AudioClip dungeonBgm;
    public bool isCharacterSelected = false;

    private bool EnterName()
    {
        if (!(nameInput.text.Length > 2 && nameInput.text.Length < 10)) return false;

        GameManager.I.name = nameInput.text;
        return true;
    }

    public void EnterDungeon()
    {
        if (EnterName() && isCharacterSelected)
        {
            SceneManager.LoadScene("MainScene");
            SoundManager.ChangeBackGroundMusic(dungeonBgm);
        }
    }
}
