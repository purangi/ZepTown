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
    public void InputProfile()
    {
        int num;
        if(dwarf_elf.isOn)
        {
            num = dwarf_fm.isOn ? 0 : 1;
        } else
        {
            num = elf_fm.isOn ? 2 : 3;
        }

        profile.sprite = profiles[num];
        GameManager.I.characterNum = num;
        _cc.isCharacterSelected = true;
    }
}
