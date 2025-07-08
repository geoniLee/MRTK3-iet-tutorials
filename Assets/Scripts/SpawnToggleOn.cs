using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UX;
using UnityEngine;

public class SpawnToggleOn : MonoBehaviour
{
    public PressableButton[] toggleButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        //씬의 모든 PressableButton 오브젝트를 찾고, 이름에 "CanvasButtonToggleSwitch"가 포함된 버튼만 필터링합니다.
        var allbuttons = Object.FindObjectsByType<PressableButton>(FindObjectsSortMode.None);
        List<PressableButton> matched = new List<PressableButton>();

        foreach (var button in allbuttons)
        {
            if (button.name.Contains("CanvasButtonToggleSwitch"))
            {
                matched.Add(button);
            }
        }

        toggleButtons = matched.ToArray();
    }

    public void SetAllToggles(bool state)
    {
        //모든 PressableButton 오브젝트를 순회하며 ForceSetToggled 메서드를 호출하여 토글 상태를 강제로 설정합니다.
        foreach (var button in toggleButtons)
        {
            if (button != null)
            {
                button.ForceSetToggled(state);
            }
        }
    }

    // 토글을 켜는 메서드
    public void SetToggleOn() => SetAllToggles(true);
    // 토글을 끄는 메서드
    public void SetToggleOff() => SetAllToggles(false);
}
