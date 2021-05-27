using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCounter : MonoBehaviour
{
    public static int counterScene = 0;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
