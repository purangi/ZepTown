using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public string name = "";
    public int characterNum = 0;

    private void Awake()
    {
        if (I == null) I = this;
        else if (I != null) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
