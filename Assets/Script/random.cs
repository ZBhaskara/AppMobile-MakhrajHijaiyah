using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int terjawab = 0;

    public void random_object()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);      
        }
        int a = UnityEngine.Random.Range(0, transform.childCount -1);

        if (transform.GetChild(a).name != "terjawab")
        {
            terjawab += 1;
            transform.GetChild(a).gameObject.SetActive(true);
            transform.GetChild(a).name = "terjawab";
        }
        else
        {
            if (terjawab < transform.childCount)
            {
                random_object();
            }
            else
            {
                print("SELESAI");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
