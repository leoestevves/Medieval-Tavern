using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteractions : MonoBehaviour
{
    [SerializeField] Transform cloneFood;
    [SerializeField] int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "Food")
        {
            Instantiate(cloneFood, new Vector3(-1.94f, 1.65f, -8.083f), cloneFood.rotation);
        }        
    }
}
