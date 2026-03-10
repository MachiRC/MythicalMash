using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class MonStats : ScriptableObject
{
    public float health;
    public float attack;
    public float spAttack;
    public float defense;
    public float spDefense;
    public float speed;
}
