using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopUp : MonoBehaviour
{
    public float timer = 0f;
    public float endTimer = 0f;

    public Vector3 position;

    public List<GameObject> items;
    //public List<GameObject> instanciatedObjects;

    public GameObject itemPrefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnItem()
    {

        for (int i = 0; i < 100; i++)
        {
            position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
            items.Add(item);

        }

    }

    public void RemoveItem(float endTimer)
    {
        if (endTimer > 5f)
        {
            Destroy(items[0]);
            items.Remove(items[0]);

            print("removed");
            print("destroyed");
            endTimer = 0f;
        }

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