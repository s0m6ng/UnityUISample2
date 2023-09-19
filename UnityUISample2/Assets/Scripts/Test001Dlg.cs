using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test001Dlg : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("InputField")]
    [SerializeField] InputField m_inpName = null;
    [Header("Text")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_inpName.onSubmit.AddListener(OnSubmit_Name);
    }

    private void OnSubmit_Name(string name)
    {
        m_txtResult.text = $"{name}";
    }

    private void OnClicked_Ok()
    {
        m_txtResult.text = $"당신이 입력한 이름은 <color=#ff0143>{m_inpName.text}</color>입니다.";
    }

    private void OnClicked_Clear()
    {
        m_inpName.text = string.Empty;
        m_txtResult.text = "Result";
    }
}
