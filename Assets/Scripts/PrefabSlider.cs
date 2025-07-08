using System;
using Microsoft.MixedReality.Toolkit.UX;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PrefabSlider : MonoBehaviour
{
    [SerializeField] private Slider scaleSlider;
    [SerializeField] private XRBaseInteractor interactor;
    GameObject lastInteractedPrefab;

    private void Start() {
        // 슬라이더 컴포넌트를 찾고, 슬라이더의 최소값을 설정합니다.
        scaleSlider.OnValueUpdated.AddListener(OnSliderValueChanged);
        scaleSlider.MinValue = 0.05f;
    }

    // 슬라이더 값이 변경될 때 호출되는 메서드입니다.
    private void OnSliderValueChanged(SliderEventData data)
    {
        if(lastInteractedPrefab != null){
            float newSize = data.NewValue;
            lastInteractedPrefab.transform.localScale = Vector3.one * newSize *2;
        }
    }

    void Update()
    {
        // XRBaseInteractor를 통해 현재 선택된 오브젝트를 가져옵니다.
        var selected = interactor.GetOldestInteractableSelected();
        GameObject current = selected?.transform?.gameObject;

        // 현재 선택된 오브젝트가 null이 아니고, 이름에 "(Clone)"이 포함되어 있으며, 마지막으로 상호작용한 프리팹과 다를 경우
        if(current != null && current.name.Contains("(Clone)")&& current != lastInteractedPrefab)
        {
            lastInteractedPrefab = current;
            scaleSlider.Value = current.transform.localScale.x/2;
        }

        // 만약 현재 선택된 오브젝트가 null이거나 이름에 "(Clone)"이 포함되지 않는다면 lastInteractedPrefab을 null로 설정합니다.
         else
        if(lastInteractedPrefab != null && !lastInteractedPrefab){
            lastInteractedPrefab = null;
        }
    }
}
