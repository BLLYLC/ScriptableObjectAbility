using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CooldownText : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI timerText;
    float cooldownTime=0;

    void Update()
    {
        cooldownTime -= Time.deltaTime;
        timerText.text = Mathf.Ceil(cooldownTime).ToString();
        
        if(cooldownTime <= 0)
        {
            DestroySelf();
        }

    }
    public void SetCooldownTime(float time)
    {
        cooldownTime = time;
    }
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
