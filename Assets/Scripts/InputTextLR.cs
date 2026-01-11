using UnityEngine;
using Unity.VRTemplate;

public class InputTextLR : MonoBehaviour
{
    [SerializeField]
    public GameObject m_gameObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("InputTextLR Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManagerLR.PrimaryButtonR())
        {
            OnPrimaryButtonR();
        }

        if (InputManagerLR.PrimaryButtonR_OnPress())
        {
            OnPressPrimaryButtonR();
        }

        if (InputManagerLR.SecondaryButtonR())
        {
            OnSecondaryButtonR();
        }

        if (InputManagerLR.SecondaryButtonR_OnPress())
        {
            OnPressSecondaryButtonR();
        }

        if (InputManagerLR.PrimaryButtonL())
        {
            OnPrimaryButtonL();
        }

        if (InputManagerLR.PrimaryButtonL_OnPress())
        {
            OnPressPrimaryButtonL();
        }

        if (InputManagerLR.SecondaryButtonL())
        {
            OnSecondaryButtonL();
        }

        if (InputManagerLR.SecondaryButtonL_OnPress())
        {
            OnPressSecondaryButtonL();
        }
    }

    void OnPrimaryButtonR()
    {
        Debug.Log("Primary Button R is Pressed");
    }

    void OnPressPrimaryButtonR()
    {
        Debug.Log("Primary Button R is OnPress");
        m_gameObject.SetActive(true);
    }

    void OnSecondaryButtonR()
    {
        Debug.Log("Secondary Button R is Pressed");
    }

    void OnPressSecondaryButtonR()
    {
        Debug.Log("Secondary Button R is OnPress");
        m_gameObject.SetActive(false);
    }

    void OnPrimaryButtonL()
    {
        Debug.Log("Primary Button L is Pressed");
    }

    void OnPressPrimaryButtonL()
    {
        Debug.Log("Primary Button L is OnPress");
        m_gameObject.SetActive(true);
    }

    void OnSecondaryButtonL()
    {
        Debug.Log("Secondary Button L is Pressed");
    }

    void OnPressSecondaryButtonL()
    {
        Debug.Log("Secondary Button L is OnPress");
        m_gameObject.SetActive(false);
    }
}

