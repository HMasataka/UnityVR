using UnityEngine;

public class ItemCountDown : MonoBehaviour
{

    public GameObject m_gameObjectRestore;

    private bool m_isGrabbed = false;
    private bool m_isTouching = false;
    public float m_grabItemTimeLimit = 3.0f;
    private float m_timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_timer = 0.0f;
    }

    public void GetGrab()
    {
        m_isGrabbed = true;
        m_isTouching = true;
    }

    public void ExitGrab()
    {
        m_isTouching = false;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (m_grabItemTimeLimit != 0)
        {
            if (m_isGrabbed == true)
            {
                if (m_isTouching == false)
                {
                    m_timer += Time.deltaTime;
                    if (m_timer >= m_grabItemTimeLimit)
                    {
                        var rigidbody = GetComponent<Rigidbody>();
                        rigidbody.velocity = Vector3.zero;
                        rigidbody.transform.position = m_gameObjectRestore.transform.position;
                        rigidbody.transform.rotation = m_gameObjectRestore.transform.rotation;
                        m_isGrabbed = false;
                        m_timer = 0.0f;
                    }
                }
                else
                {
                    m_timer = 0.0f;
                }
            }
        }
    }
}
