using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 arah;
    [SerializeField] Vector3 rotate;
    [SerializeField] Space space;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start");
    }

    private void OnDisable()
    {
        // Debug.Log(gameObject.name + " disabled");
    }

    private void OnDestroy()
    {
        // Debug.Log(gameObject.name + " destroyed");
    }


    // Update is called once per frame

    Vector3 rot;

    float timer = 0;
    void Update()
    {
        // transform.Translate(arah*Time.deltaTime,space); 
        // transform.position = transform.position + arah*Time.deltaTime; 
        // transform.localPosition = transform.localPosition + arah*Time.deltaTime; 

        // transform.Rotate(rotate*Time.deltaTime,space); 
        // rot += rotate*Time.deltaTime;
        // transform.rotation = Quaternion.Euler(rot) ; 
        // transform.localRotation = Quaternion.Euler(rot) ; 

        // transform.localScale *= 1 + Time.deltaTime;       
        // gameObject.SetActive(false);
        timer += Time.deltaTime;

        if (timer >= 2)
            Destroy(gameObject);
                
    }
}
