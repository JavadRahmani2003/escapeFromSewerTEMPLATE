using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStart : MonoBehaviour
{
    public void LoadPlayerNextLVL()
    {
        SceneManager.LoadScene("Level");
    }
}
