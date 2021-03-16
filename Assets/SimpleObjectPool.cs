using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private Stack<GameObject> inactiveInsatances = new Stack<GameObject>();
    public GameObject GetObject()
    {
        GameObject spawnedGameObject;
        if (inactiveInsatances.Count > 0)
        {
            spawnedGameObject = inactiveInsatances.Pop();
        }
        else
        {
            spawnedGameObject = (GameObject)GameObject.Instantiate(prefab);
            PooledObject pooledObject = spawnedGameObject.AddComponent<PooledObject>();
            pooledObject.pool = this;
        }
        spawnedGameObject.SetActive(true);
        return spawnedGameObject;
    }
    public void ReturnObject(GameObject toReturn)
    {
        PooledObject pooledObject = toReturn.GetComponent<PooledObject>();
        if (pooledObject != null && pooledObject.pool == this)
        {
            toReturn.SetActive(false);
            inactiveInsatances.Push(toReturn);
        }
        else
        {
            Debug.Log(toReturn.name + " fue devuelto a una piscina de la que no se generó");
            Destroy(toReturn);
        }
    }
}
public class PooledObject : MonoBehaviour
{
    public SimpleObjectPool pool;
}
