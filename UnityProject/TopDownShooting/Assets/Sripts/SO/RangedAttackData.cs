using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RangedAttackData",
    menuName = "TopDownController/Attacks/Ranged",
    order = 1)]
public class RangedAttackData : AttackSO
{
    [Header("Ranged Attack Data", order = 1)]
    public string bulletNameTag;
    public float duration;
    public float spread;
    public int numberofProjectPerShot;
    public float mutipleProjectilesAngel;
    public Color projectileColor;
}
