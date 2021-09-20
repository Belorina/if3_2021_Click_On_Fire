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
        // StartCoroutine("Spawn");

    }

    public void SpawnItem()
    {
        GameObject item = Instantiate(itemPrefab, new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
        items.Add(item);

    }

    // IEnumerator RemoveItem()
    // {
    //     yield return new WaitForSeconds(5f);
    //     Destroy(items[0]);
    //     items.Remove(items[0]);
    // }
    public void RemoveItem()
    {
        if (items.Count > 0)
        {
            Destroy(items[0]);
            items.Remove(items[0]);
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