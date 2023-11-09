using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Enemy")]
public class Enemy : ScriptableObject
{
    [Header("Appearance")]
    public string displayName;
    public Sprite image;
    
    [Header("Statistics")]
    public Endurance endurance;
    public double damage;
}