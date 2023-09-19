using UnityEngine;
using UnityEngine.UI;

public class Test006Dlg : MonoBehaviour
{
    [Header("Scrollbar")]
    [SerializeField] Scrollbar m_scbScrollbar = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_scbScrollbar.onValueChanged.AddListener(OnValueChanged_Scb);
        OnClicked_Clear();
    }

    private void OnValueChanged_Scb(float value)
    {
        m_txtResult.text = $"<color=#fbf321>{value:F2}</color>";
    }


    private void OnClicked_Ok()
    {
        m_txtResult.text = $"현재 진행된 값은 <color=#faf230>{m_scbScrollbar.value:F2}</color> 입니다.";
    }

    private void OnClicked_Clear()
    {
        m_scbScrollbar.value = 0;
        m_txtResult.text = "Result";
    }
}
