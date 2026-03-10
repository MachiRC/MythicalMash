using UnityEngine;

[CreateAssetMenu(fileName = "Monsters", menuName = "Scriptable Objects/Monsters")]
public class Monsters : ScriptableObject
{
    public string monName;
    public Sprite monSprite;
    public MonStats stats;
    Move[] moves;

    string[] types; 

}
