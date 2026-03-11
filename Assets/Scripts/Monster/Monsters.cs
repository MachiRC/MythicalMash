using UnityEngine;

[CreateAssetMenu(fileName = "Monsters", menuName = "Scriptable Objects/Monsters")]
public class Monsters : ScriptableObject
{
    public string monName;
    public Sprite monSprite;
    public MonStats stats;
    public Move[] moves;

    public string[] types; 

}
