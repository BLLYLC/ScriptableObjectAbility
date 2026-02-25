using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlotsUI : MonoBehaviour
{
    [SerializeField]private List<GameObject> abilityIcons;
    private List<AbilityBase> abilities;
    [SerializeField] private GameObject selectorFrame;
    
    private void Start()
    { 
        abilities = AbilityController.instance.GetAbilityList();
        for(int i = 0; i < abilityIcons.Count; i++)
        {
            if (i < abilities.Count)
            {
                Image img = abilityIcons[i].GetComponent<Image>();
                img.sprite = abilities[i].abilitySprite;
            }
            else
            {
                Image img = abilityIcons[i].GetComponent<Image>();
                img.sprite = null;
            }
        }
       
        AbilityController.instance.OnNewSpellSelected += AbilityController_OnNewSpellSelected;
    }

    private void AbilityController_OnNewSpellSelected(int currentIndex)
    {
        selectorFrame.transform.position = abilityIcons[currentIndex].transform.position;
    }
}
