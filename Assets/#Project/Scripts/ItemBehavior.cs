using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : PopUp
{
    public Renderer rend;

    public float onScreenTime = 0f;

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
        onScreenTime += Time.deltaTime;

        if (onScreenTime >= 5f)
        {
            RemoveItem();
        }
    }
}
