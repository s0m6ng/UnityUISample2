using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003Dlg : MonoBehaviour
{
    [Header("Toggle")]
    [SerializeField] List<Toggle> m_tglList = new List<Toggle>();
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    List<string> m_Fruits = new List<string>() { "사과","배","오렌지"};
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        for (int i = 0; i < m_tglList.Count; i++)
        {
            int index = i;
            m_tglList[i].onValueChanged.AddListener((isOn) => OnValueChanged_Fruit(isOn, index));
        }
    }

    private void OnValueChanged_Fruit(bool isOn, int index)
    {
        if (isOn)
            m_txtResult.text = $"<color=#fbf321>{m_Fruits[index]}</color> 선택";
    }


    private void OnClicked_Ok()
    {
        m_txtResult.text = "당신이 좋아하는 과일은 ";
        for (int i = 0; i < m_tglList.Count; i++)
        {
            if (m_tglList[i].isOn)
            {
                m_txtResult.text += $"<color=#fa0063>{m_Fruits[i]}</color>";
                break;
            }
        }
        m_txtResult.text += " 입니다.";
    }

    private void OnClicked_Clear()
    {
        m_tglList[0].isOn = false;
        m_txtResult.text = "Result";
    }
}
