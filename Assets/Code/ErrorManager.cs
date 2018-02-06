using UnityEngine;
using System.Collections;

public class ErrorManager : MonoBehaviour
{
    public GameObject m_previousScreen;

    public void PushError(GameObject previousScreen)
    {
        m_previousScreen = previousScreen;
        gameObject.SetActive(true);
        m_previousScreen.SetActive(false);
    }

    public void PopError()
    {
        gameObject.SetActive(false);
        m_previousScreen.SetActive(true);
    }
}
