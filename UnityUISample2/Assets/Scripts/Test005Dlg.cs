using UnityEngine;
using UnityEngine.UI;

public class Test005Dlg : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] Slider m_sldR = null;
    [SerializeField] Slider m_sldG = null;
    [SerializeField] Slider m_sldB = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Text")]
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Text m_txtR = null;
    [SerializeField] Text m_txtG = null;
    [SerializeField] Text m_txtB = null;
    byte m_red = 0;
    byte m_green = 0;
    byte m_blue = 0;
    Color32 m_Color = new Color32();
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_sldR.onValueChanged.AddListener((value) => OnValueChanged_Sld(value, ref m_red, ref m_txtR));
        m_sldG.onValueChanged.AddListener((value) => OnValueChanged_Sld(value, ref m_green, ref m_txtG));
        m_sldB.onValueChanged.AddListener((value) => OnValueChanged_Sld(value, ref m_blue, ref m_txtB));
        OnClicked_Clear();
    }

    private void OnValueChanged_Sld(float value, ref byte color, ref Text txt)
    {
        color = (byte)value;
        txt.text = $"{value}";
        m_Color = new Color32(m_red, m_green, m_blue, 255);
        m_txtResult.color = m_Color;
        m_txtResult.text = $"현재 색상 값 입니다.";
    }


    private void OnClicked_Ok()
    {
        m_txtResult.text = $"당신이 선택한 색깔은 R:{m_red} G:{m_green} B:{m_blue} 입니다.";
        m_txtResult.color = m_Color;
    }

    private void OnClicked_Clear()
    {
        m_sldR.value = 255;
        m_sldG.value = 255;
        m_sldB.value = 255;
        m_txtResult.text = "Result";
    }
}
