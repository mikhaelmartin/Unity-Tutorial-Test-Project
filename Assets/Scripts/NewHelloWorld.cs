using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHelloWorld : MonoBehaviour
{
    // [SerializeField] string varString = "ini variabel string";
    // [SerializeField, Range(0, 10)] float varFloat = 52f;

    private void Awake() {
        // Debug.Log("Awake");
    }
    
    private void OnEnable() {
        // Debug.Log("OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start");
        Debug.Log(gameObject.name); 
    }
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward*360*Time.deltaTime);
        // Debug.Log("Update");
    // Debug.Log(Time.deltaTime);
    //     if (Input.GetKeyDown(KeyCode.A))
    //     {
    //         Debug.Log("GetKeyDown");
    //     }

    //     if (Input.GetKeyUp(KeyCode.A))
    //     {
    //         Debug.Log("GetKeyUp");
    //     }

    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         Debug.Log("GetKey");
    //     }

    }

    private void OnDisable() {
        // Debug.Log("OnDisable");
    }

    private void OnDestroy() {
        // Debug.Log("OnDestroy");
    }

    private void FixedUpdate() {
        
    }
}
