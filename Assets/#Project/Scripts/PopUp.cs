using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopUp : MonoBehaviour
{
    public float timer = 0f;

    public float onScreenTime = 0f;

    private Vector3 position;

    public List<GameObject> items;
    //public List<GameObject> instanciatedObjects;

    public GameObject itemPrefab;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnItem()
    {
        GameObject item = Instantiate(itemPrefab, new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
        items.Add(item);

    }

    public void RemoveItem()
    {
        if (onScreenTime >= 5f)
        {
            Destroy(items[0]);

            items.Remove(items[0]);
            onScreenTime = 0f;
            print("removed");
            print("destroyed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        onScreenTime += Time.deltaTime;

        if (items.Count < 10)
        {
            if (timer >= 1f)
            {
                SpawnItem();
                timer = 0f;

                RemoveItem();
            }



        }

    }

}