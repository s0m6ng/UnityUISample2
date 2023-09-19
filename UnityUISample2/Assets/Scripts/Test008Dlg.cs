using System;
using UnityEngine;
using UnityEngine.UI;

public class Test008Dlg : MonoBehaviour
{
    [Header("Dropdown")]
    [SerializeField] Dropdown m_drdDropdown = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_drdDropdown.onValueChanged.AddListener(OnValueChanged_Drd);
        OnClicked_Clear();
    }

    private void OnValueChanged_Drd(int index)
    {
        m_txtResult.text = $"{index}: {m_drdDropdown.options[index].text}";
    }

    private void OnClicked_Ok()
    {
        m_txtResult.text = $"당신이 이동할 도시는 {m_drdDropdown.captionText.text}입니다.";
    }

    private void OnClicked_Clear()
    {
        m_txtResult.text = "Result";
        m_drdDropdown.value = 0;
    }
}
