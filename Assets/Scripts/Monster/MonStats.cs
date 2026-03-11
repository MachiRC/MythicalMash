using UnityEngine;

[CreateAssetMenu(fileName = "MonStats", menuName = "Scriptable Objects/MonStats")]
public class MonStats : ScriptableObject
{
    public float health;
    public float attack;
    public float spAttack;
    public float defense;
    public float spDefense;
    public float speed;
}
