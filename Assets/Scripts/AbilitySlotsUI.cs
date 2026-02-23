using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlotsUI : MonoBehaviour
{
    [SerializeField]private List<GameObject> abilityIcons;
    [SerializeField] private List<AbilityBase> abilities;
    
    void Start()
    {
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

    }

    
}
