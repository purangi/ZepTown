using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public static ProjectileManager instance;

    private ObjectPool objectPool;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        objectPool = GetComponent<ObjectPool>();
    }

}
