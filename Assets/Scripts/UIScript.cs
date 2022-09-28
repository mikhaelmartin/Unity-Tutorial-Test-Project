using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform rect;
    Image image;
    SpriteRenderer rend;
    void Start()
    {
        image = GetComponent<Image>();
              
        if (rect == null)
            rect = GetComponent<RectTransform>();
        var button = GetComponent<Button>();

        if (button == null)
            gameObject.AddComponent<Button>();

        Debug.Log(rect);
        Debug.Log(button);
    }

    // Update is called once per frame
    // float timer = 0;
    void Update()
    {
        if (rect.anchoredPosition.y < 0)
        {
            rect.anchoredPosition += new Vector2(0, 50) * Time.deltaTime;
        }
        
    }
}
