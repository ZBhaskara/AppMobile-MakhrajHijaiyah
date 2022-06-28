using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombol : MonoBehaviour
{
    public GameObject ba1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        ba1.GetComponent<Animator>().SetTrigger("play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
