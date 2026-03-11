using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Scriptable Objects/Move")]
public class Move : ScriptableObject
{
    public string moveName;
    public float power;
    public float points;
    public float accuracy;
    public string type;

    public bool isAttack;
    public bool isPhysical;

}
