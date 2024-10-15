using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DefaultEnemyData",menuName ="TopDownController/Enemy/Stats",order =20)]
public class EnemySO : ScriptableObject
{
    public float health = 3f;
    public float power = 4f;
    public float speed = 3f;
}
