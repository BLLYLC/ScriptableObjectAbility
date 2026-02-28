using UnityEngine;
[CreateAssetMenu(fileName = "ShockwaveAbility", menuName = "ScriptableObjects/AbilityBase/ShockwaveAbility")]

public class ShockwaveAbility : AbilityBase
{

    public override void Activate(GameObject owner)
    {
        Vector3 shockwavePosition = owner.transform.position; 
        Collider[] hitColliders = Physics.OverlapSphere(shockwavePosition, 10f);
        foreach (Collider hitCollider in hitColliders)
        {
            Rigidbody rb = hitCollider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = hitCollider.transform.position - shockwavePosition;
                rb.AddForce(direction.normalized * 500f);
            }
        }
    }
}
