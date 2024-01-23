using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKey : MonoBehaviour
{
    [SerializeField] private GameObject cc;
    private CanvasGroup title;
    private float fadeSpeed = 0.8f;

    // Start is called before the first frame update
    void Awake()
    {
        title = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            //SceneManager.LoadScene("CharacterCreate");
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        while (title.alpha > 0)
        {
            title.alpha -= Time.deltaTime * fadeSpeed;
            yield return null;
        }

        DestroyObject();
    }

    void  DestroyObject()
    {
        cc.SetActive(true);
        Destroy(gameObject);
    }
}
