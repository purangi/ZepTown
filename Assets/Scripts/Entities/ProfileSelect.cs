using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileSelect : MonoBehaviour
{
    [SerializeField] private Toggle dwarf_elf;
    [SerializeField] private Toggle dwarf_fm;
    [SerializeField] private Toggle elf_fm;

    [SerializeField] private Image profile;
    [SerializeField] private Sprite[] profiles;

    [SerializeField] private CharacterCreate _cc;
    //[SerializeField] private Player _player;
    public void InputProfile()
    {
        SetCharacterNum();
        profile.sprite = profiles[GameManager.I.characterNum];
        _cc.isCharacterSelected = true;
    }

    public void changeCharacter(Player _player)
    {
        SetCharacterNum();
        _player.SetCharacter();
    }

    public void SetCharacterNum()
    {
        int num;
        if (dwarf_elf.isOn)
        {
            num = dwarf_fm.isOn ? 0 : 1;
        }
        else
        {
            num = elf_fm.isOn ? 2 : 3;
        }

        GameManager.I.characterNum = num;
    }
}
