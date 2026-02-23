using UnityEngine;

[CreateAssetMenu(fileName = "AbilityBase", menuName = "ScriptableObjects/AbilityBase")]
public abstract class AbilityBase : ScriptableObject
{
    public string abilityName;
    public float cooldown;
    public Sprite abilitySprite;
    public abstract void Activate(GameObject owner);

}
