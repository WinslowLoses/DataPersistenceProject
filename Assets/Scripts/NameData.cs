using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameData : MonoBehaviour
{
    public TMP_InputField input;
    
    public static NameData Instance;

    public string Name;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateName()
    {
        Name = input.text;
    }
}
