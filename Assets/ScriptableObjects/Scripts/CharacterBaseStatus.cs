using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterBaseStatus", menuName = "ScriptableObjects/CharacterBaseStatus", order = 0)]
public class CharacterBaseStatus : ScriptableObject
{
    [Header("Status Info")]
    public int hp;
    public int mp;
    public int attack;
    public int defence;
}
