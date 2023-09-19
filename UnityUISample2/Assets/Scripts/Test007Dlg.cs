using UnityEngine;
using UnityEngine.UI;

public class Test007Dlg : MonoBehaviour
{
    [Header("Scrollbar")]
    [SerializeField] Scrollbar m_scbScrollbar = null;
    [Header("Button")]
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [Header("Other")]
    [SerializeField] Text m_txtResult = null;
    bool m_isStart = false;
    float m_alphaTimer = 0;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
        m_scbScrollbar.onValueChanged.AddListener(OnValueChanged_Scb);
        OnClicked_Stop();
    }
    private void Update()
    {
        if (m_scbScrollbar.value < 1)
        {
            if (m_isStart)
            {
                m_alphaTimer += Time.deltaTime;
                if (m_alphaTimer >= 0.5f)
                {
                    m_alphaTimer = 0;
                    m_scbScrollbar.value += 0.05f;
                }
            }
        }
        else
            m_scbScrollbar.value = 1;
    }
    private void OnValueChanged_Scb(float value)
    {
        m_txtResult.text = $"{value:F2}";
        m_txtResult.color = new Color(1, 1, 1, value);
    }


    private void OnClicked_Start()
    {
        m_isStart = true;
    }

    private void OnClicked_Stop()
    {
        m_isStart = false;
        m_scbScrollbar.value = 0;
    }
}
