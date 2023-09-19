using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test002Dlg : MonoBehaviour
{
    [Header("Toggle")]
    [SerializeField] List<Toggle> m_tglList = new List<Toggle>();
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
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
        string fruit = m_tglList[index].transform.GetChild(1).GetComponent<Text>().text;
        if (isOn)
            m_txtResult.text = $"{fruit} 선택";
        else
            m_txtResult.text = $"{fruit} 취소";
    }


    private void OnClicked_Ok()
    {
        m_txtResult.text = "당신이 좋아하는 과일은";
        int temp = 0;
        for (int i = 0; i < m_tglList.Count; i++)
        {
            if (m_tglList[i].isOn)
            {
                m_txtResult.text += $"{(temp == 0 ? "" : ",")} {m_tglList[i].transform.GetChild(1).GetComponent<Text>().text}";
                temp++;
            }
        }
        m_txtResult.text += " 입니다.";
        if (temp == 0)
        {
            m_txtResult.text = "선택한 과일이 없습니다.";
        }
    }

    private void OnClicked_Clear()
    {
        for (int i = 0; i < m_tglList.Count; i++)
        {
            m_tglList[i].isOn = false;
        }
        m_txtResult.text = "Result";
    }
}
