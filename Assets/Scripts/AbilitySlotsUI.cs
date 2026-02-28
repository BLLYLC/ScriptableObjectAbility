using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlotsUI : MonoBehaviour
{
    [SerializeField]private List<GameObject> abilityIcons;
    private List<AbilityBase> abilities;
    [SerializeField] private GameObject selectorFrame;
    [SerializeField] private GameObject cooldownCountdownPrefab;

    private void Start()
    { 
       abilities = AbilityController.instance.GetAbilityList();
       SetIcons();
        AbilityController.instance.OnNewSpellSelected += AbilityController_OnNewSpellSelected;
        AbilityController.instance.OnAbilityUsed += AbilityController_OnAbilityUsed; ;
    }

    private void AbilityController_OnAbilityUsed(int currentIndex)
    {
        Instantiate(cooldownCountdownPrefab, abilityIcons[currentIndex].transform.position, Quaternion.identity, transform).GetComponent<CooldownText>().SetCooldownTime(abilities[currentIndex].cooldown);
    }

    private void AbilityController_OnNewSpellSelected(int currentIndex)
    {
        selectorFrame.transform.position = abilityIcons[currentIndex].transform.position;
    }
    private void SetIcons()
    {
        for (int i = 0; i < abilityIcons.Count; i++)
        {
            if (i < abilities.Count)
            {
                Image img = abilityIcons[i].GetComponent<Image>();
                img.sprite = abilities[i].abilitySprite;
                img.color = Color.white;
            }
            else
            {
                Image img = abilityIcons[i].GetComponent<Image>();
                img.sprite = null;
            }
        }
    }
}
