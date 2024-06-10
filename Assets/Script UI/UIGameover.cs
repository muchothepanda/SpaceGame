using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameover : MonoBehaviour
{
    public void EndScene()
    {
        SceneManager.LoadScene(2);
    }
}
