using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PS4Controller : MonoBehaviour
{
    [SerializeField] private bool showDebug = true;

    [System.Serializable]
    public class AxisEvent : UnityEvent<string, float>
    {
    }

    public AxisEvent m_LeftStickX,
                        m_LeftStickY,
                        m_RightStickX,
                        m_RightStickY,
                        m_DPadX,
                        m_DPadY,
                        m_L2Axis,
                        m_R2Axis;

    [System.Serializable]
    public class ButtonEvent : UnityEvent<string>
    {
    }

    public ButtonEvent m_Square,
                        m_X,
                        m_Circle,
                        m_Triangle,
                        m_L1,
                        m_L2Button,
                        m_L3,
                        m_R1,
                        m_R2Button,
                        m_R3,
                        m_PS,
                        m_Pad,
                        m_Share,
                        m_Options;

    void Awake()
    {
        if (m_LeftStickX == null) m_LeftStickX = new AxisEvent();
        if (m_LeftStickY == null) m_LeftStickY = new AxisEvent();
        if (m_RightStickX == null) m_RightStickX = new AxisEvent();
        if (m_RightStickY == null) m_RightStickY = new AxisEvent();
        if (m_DPadX == null) m_DPadX = new AxisEvent();
        if (m_DPadY == null) m_DPadY = new AxisEvent();
        if (m_L2Axis == null) m_L2Axis = new AxisEvent();
        if (m_R2Axis == null) m_R2Axis = new AxisEvent();

        if (m_Square == null) m_Square = new ButtonEvent();
        if (m_X == null) m_X = new ButtonEvent();
        if (m_Circle == null) m_Circle = new ButtonEvent();
        if (m_Triangle == null) m_Triangle = new ButtonEvent();
        if (m_L1 == null) m_L1 = new ButtonEvent();
        if (m_L2Button == null) m_L2Button = new ButtonEvent();
        if (m_L3 == null) m_L3 = new ButtonEvent();
        if (m_R1 == null) m_R1 = new ButtonEvent();
        if (m_R2Button == null) m_R2Button = new ButtonEvent();
        if (m_R3 == null) m_R3 = new ButtonEvent();
        if (m_PS == null) m_PS = new ButtonEvent();
        if (m_Pad == null) m_Pad = new ButtonEvent();
        if (m_Share == null) m_Share = new ButtonEvent();
        if (m_Options == null) m_Options = new ButtonEvent();

    }

    void Update()
    {
        CheckAxis("LeftStickX", m_LeftStickX);
        CheckAxis("LeftStickY", m_LeftStickY);
        CheckAxis("RightStickX", m_RightStickX);
        CheckAxis("RightStickY", m_RightStickY);
        CheckAxis("DPadX", m_DPadX);
        CheckAxis("DPadY", m_DPadY);
        CheckAxis("L2Axis", m_L2Axis);
        CheckAxis("R2Axis", m_R2Axis);

        CheckButton("Square", m_Square);
        CheckButton("X", m_X);
        CheckButton("Circle", m_Circle);
        CheckButton("Triangle", m_Triangle);
        CheckButton("L1", m_L1);
        CheckButton("L2Button", m_L2Button);
        CheckButton("L3", m_L3);
        CheckButton("R1", m_R1);
        CheckButton("R2Button", m_R2Button);
        CheckButton("R3", m_R3);
        CheckButton("PS", m_PS);
        CheckButton("Pad", m_Pad);
        CheckButton("Share", m_Share);
        CheckButton("Options", m_Options);
    }

    private void CheckAxis(string controlName, AxisEvent EventCallback)
    {
        if (System.Math.Abs(Input.GetAxis(controlName)) > Mathf.Epsilon)
        {
            if (showDebug) Debug.Log(controlName + ": " + Input.GetAxis(controlName));
            EventCallback.Invoke(controlName, Input.GetAxis(controlName));
        }
    }

    private void CheckButton(string controlName, ButtonEvent EventCallback)
    {
        if (Input.GetButton(controlName))
        {
            if (showDebug) Debug.Log(controlName);
            EventCallback.Invoke(controlName);
        }
    }
}
