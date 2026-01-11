using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerLR : MonoBehaviour
{
    static InputManagerLR m_instance;

    [SerializeField]
    InputActionAsset m_actionAsset;

    InputActionMap m_ActionMap;
    InputAction m_PrimaryButtonR;
    InputAction m_PrimaryButtonL;
    InputAction m_SecondaryButtonR;
    InputAction m_SecondaryButtonL;

    private void Awake()
    {
        m_instance = this;
        DontDestroyOnLoad(this.gameObject);

        m_ActionMap = m_actionAsset.FindActionMap("Test");

        m_PrimaryButtonR = m_ActionMap.FindAction("XR_PrimaryButtonR", throwIfNotFound: true);
        m_PrimaryButtonL = m_ActionMap.FindAction("XR_PrimaryButtonL", throwIfNotFound: true);

        m_SecondaryButtonR = m_ActionMap.FindAction("XR_SecondaryButtonR", throwIfNotFound: true);
        m_SecondaryButtonL = m_ActionMap.FindAction("XR_SecondaryButtonL", throwIfNotFound: true);
    }

    private void OnEnable()
    {
        m_ActionMap?.Enable();
    }

    private void OnDisable()
    {
        m_ActionMap?.Disable();
    }

    public static bool PrimaryButtonR()
    {
        return m_instance.m_PrimaryButtonR.IsPressed();
    }

    public static bool PrimaryButtonR_OnPress()
    {
        return m_instance.m_PrimaryButtonR.WasPressedThisFrame();
    }

    public static bool PrimaryButtonR_OnRelease()
    {
        return m_instance.m_PrimaryButtonR.WasReleasedThisFrame();
    }

    public static bool SecondaryButtonR()
    {
        return m_instance.m_SecondaryButtonR.IsPressed();
    }

    public static bool SecondaryButtonR_OnPress()
    {
        return m_instance.m_SecondaryButtonR.WasPressedThisFrame();
    }

    public static bool SecondaryButtonR_OnRelease()
    {
        return m_instance.m_SecondaryButtonR.WasReleasedThisFrame();
    }

    public static bool PrimaryButtonL()
    {
        return m_instance.m_PrimaryButtonL.IsPressed();
    }

    public static bool PrimaryButtonL_OnPress()
    {
        return m_instance.m_PrimaryButtonL.WasPressedThisFrame();
    }

    public static bool PrimaryButtonL_OnRelease()
    {
        return m_instance.m_PrimaryButtonL.WasReleasedThisFrame();
    }

    public static bool SecondaryButtonL()
    {
        return m_instance.m_SecondaryButtonL.IsPressed();
    }

    public static bool SecondaryButtonL_OnPress()
    {
        return m_instance.m_SecondaryButtonL.WasPressedThisFrame();
    }

    public static bool SecondaryButtonL_OnRelease()
    {
        return m_instance.m_SecondaryButtonL.WasReleasedThisFrame();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("InputManagerLR Start");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
