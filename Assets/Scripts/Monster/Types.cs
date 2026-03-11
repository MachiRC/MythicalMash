using UnityEngine;

[CreateAssetMenu(fileName = "Types", menuName = "Scriptable Objects/Types")]
public class Types : ScriptableObject
{
    public Sprite typeImg;

    public Types[] weakTo;
    public Types[] strongAgainst;

    public Types[] resists;
    public Types[] immuneTo;

}
