using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : PopUp
{
    public Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {

        endTimer += Time.deltaTime;

        if (endTimer >= 5f)
        {
            RemoveItem(endTimer);
        }


    }
}
