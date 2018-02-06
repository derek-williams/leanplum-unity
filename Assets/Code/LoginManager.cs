using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour 
{
    public InputField m_username;
    public InputField m_password;

    public GameObject m_LoginSuccessScreen;
    public ErrorManager m_Error;
    public GameObject m_CreateAccountScreen;

    public void Login()
    {
        if(PlayerPrefs.HasKey(m_username.text))
        {
            DisplayNextScreen(m_password.text == PlayerPrefs.GetString(m_username.text));
        }
        else
        {
            DisplayNextScreen(false);
        }
    }

    public void CreateAccount()
    {
        m_CreateAccountScreen.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ForgotAccount()
    {
        DisplayNextScreen(false);
    }

    private void DisplayNextScreen(bool success)
    {
        if(success)
        {
            m_LoginSuccessScreen.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            //Debug.Log("error");
            m_Error.PushError(gameObject);
        }
    }
}
