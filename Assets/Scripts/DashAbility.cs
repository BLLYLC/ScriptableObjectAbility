using UnityEngine;

[CreateAssetMenu(fileName ="DashAbility",menuName= "ScriptableObjects/AbilityBase/DashAbility")]
public class DashAbility : AbilityBase
{
    
    public float dashSpeed=100f;
    public override void Activate(GameObject owner)
    {
        PlayerMovement pm = owner.GetComponent<PlayerMovement>();
        Vector2 moveInput = pm.GetMoveinput();
        Transform cameraTransform = pm.GetCameraTransform();
        Vector3 move;
        if (moveInput.x == 0 && moveInput.y == 0)
        {
            move = cameraTransform.forward;
        }
        else
        {
            move = cameraTransform.forward * moveInput.x + cameraTransform.right * moveInput.y;
        }
            
        move.y = 0;
        move.Normalize();

        owner.transform.position += move * dashSpeed * Time.deltaTime;

    }
}
