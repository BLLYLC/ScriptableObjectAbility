using UnityEngine;
[CreateAssetMenu(fileName = "SpawnAbility", menuName = "ScriptableObjects/AbilityBase/SpawnAbility")]

public class SpawnAbility : AbilityBase
{
    [SerializeField] private GameObject objectToSpawn;
    public override void Activate(GameObject owner)
    {
        PlayerMovement pm =owner.GetComponent<PlayerMovement>();
        Instantiate(objectToSpawn, pm.GetCameraTransform().position + pm.GetCameraTransform().forward * 2, Quaternion.identity);
    }
}
