using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityController : MonoBehaviour
{
    [SerializeField]private List<AbilityBase> abilities;
    private List<float> lastUseTimeList;
    int currentIndex=0;
    float time;
    private void Start()
    {
        lastUseTimeList = new List<float>();
        for (int i = 0; i < abilities.Count; i++) {
            lastUseTimeList.Add(0f);
        }
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (Keyboard.current.digit1Key.wasPressedThisFrame) { currentIndex = 0;}
        if (Keyboard.current.digit2Key.wasPressedThisFrame) { currentIndex = 1; }
        if (Keyboard.current.digit3Key.wasPressedThisFrame) { currentIndex = 2; }
        if (Keyboard.current.digit4Key.wasPressedThisFrame) { currentIndex = 3; }
        if (Keyboard.current.digit5Key.wasPressedThisFrame) { currentIndex = 4; }
        if (Keyboard.current.digit6Key.wasPressedThisFrame) { currentIndex = 5; }
        if (Keyboard.current.digit7Key.wasPressedThisFrame) { currentIndex = 6; }
        if (Keyboard.current.digit8Key.wasPressedThisFrame) { currentIndex = 7; }
        if (Keyboard.current.digit9Key.wasPressedThisFrame) { currentIndex = 8; }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ActivateCurrentAbility();
        }

    }
    public void ActivateCurrentAbility()
    {
        if (currentIndex>=abilities.Count)
        {
            return;
        }
        var ability = abilities[currentIndex];

        if (time - lastUseTimeList[currentIndex] > ability.cooldown)
        {
            ability.Activate(gameObject);
            lastUseTimeList[currentIndex] = time;
        }

    }

}
