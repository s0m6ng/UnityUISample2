using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004Dlg : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] Slider m_sldSlider = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_sldSlider.onValueChanged.AddListener(OnValueChanged_Sld);
    }

    private void OnValueChanged_Sld(float value)
    {
            m_txtResult.text = $"<color=#fbf321>{value}</color>";
    }


    private void OnClicked_Ok()
    {
        m_txtResult.text = $"당신이 선택한 색깔은 <color=#faf230>{m_sldSlider.value}</color> 입니다.";
    }

    private void OnClicked_Clear()
    {
        m_sldSlider.value = 0 ;
        m_txtResult.text = "Result";
    }
}
