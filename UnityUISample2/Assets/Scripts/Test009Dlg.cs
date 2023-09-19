using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test009Dlg : MonoBehaviour
{
    [Header("Dropdown")]
    [SerializeField] Dropdown m_drdDropdown = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    List<string> optionList = new List<string>() { "����", "������", "����", "�ƻ�", "��õ", "�ͻ�" };
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_drdDropdown.onValueChanged.AddListener(OnValueChanged_drd);
        m_drdDropdown.ClearOptions();
        m_drdDropdown.AddOptions(optionList);
    }

    private void OnValueChanged_drd(int index)
    {
        m_txtResult.text = m_drdDropdown.options[index].text;
    }

    private void OnClicked_Ok()
    {
        m_txtResult.text = $"����� �̵��� ���ô� <color=#f88030>{m_drdDropdown.captionText.text}</color>�Դϴ�.";
    }

    private void OnClicked_Clear()
    {
        m_drdDropdown.value = 0;
        m_txtResult.text = "Result";
    }
}
