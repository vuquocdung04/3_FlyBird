using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public void Button_Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Button_Quit()
    {
        Application.Quit();
    }
}
