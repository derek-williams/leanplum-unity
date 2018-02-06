using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateAccountManager : MonoBehaviour
{
    public GameObject m_LoginScreen;
    public InputField m_username;
    public InputField m_password;
    public InputField m_passwordConfirmation;

    public ErrorManager m_Error;

    public bool CheckAccountExists()
    {
        return (PlayerPrefs.HasKey(m_username.text));
    }

    public void CheckPassword()
    {
        if(!CheckAccountExists())
        {
            if(!string.IsNullOrEmpty(m_password.text) && m_password.text == m_passwordConfirmation.text)
            {
                CreateAccount();
            }
            else
            {
                //display error
                m_Error.PushError(gameObject);
            }
        }
        else
        {
            //displau error
            m_Error.PushError(gameObject);
        }
    }

    public void CreateAccount()
    {
        //create account
        PlayerPrefs.SetString(m_username.text, m_password.text);
        m_LoginScreen.SetActive(true);
        gameObject.SetActive(false);
        //display login
    }
}
