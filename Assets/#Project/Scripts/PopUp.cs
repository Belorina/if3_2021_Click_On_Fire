using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopUp : MonoBehaviour
{
    public float timer = 0f;

    private Vector3 position;

    public List<GameObject> items;
    //public List<GameObject> instanciatedObjects;

    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // public void Fill()
    // {
    //     // instanciatedObjects = new List<GameObject>();
    //     // for (int i = 0; i < 10; i ++)
    //     // {
    //     //     instanciatedObjects.Add(Instantiate(items[i]) as GameObject);
    //     // }

    //     for (int i = 0; i < 10; i++)
    //     {
    //         GameObject itemPop = Instantiate(itemPrefab, position, Quaternion.identity);
    //         position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    //         items.Add(itemPop);

    //         Destroy(itemPop);
    //         //print(items);
    //     }

    // }

    public void SpawnItem()
    {
        GameObject item = Instantiate(itemPrefab, new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
        items.Add(item);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (items.Count < 10)
        {
            if (timer >= 1f)
            {
                SpawnItem();
                timer = 0f;
            }

        }

    }

}