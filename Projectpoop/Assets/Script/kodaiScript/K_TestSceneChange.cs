using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class K_TestSceneChange : MonoBehaviour
{
    public void K_StartSceneChange()
    {
        SceneManager.LoadScene("kodaiMain");
    }
}
