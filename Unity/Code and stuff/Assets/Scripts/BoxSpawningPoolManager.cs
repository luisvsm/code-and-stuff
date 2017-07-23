using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawningPoolManager : ManagedMonoBehaviour {


    public GameObject box;

    List<GameObject> boxes;

    public int numberOfBoxesToInstantiate;

    int lastActiveIndex;

    // Use this for initialization
    void Start() {

    }

    void Boot()
    {


        lastActiveIndex = 0;

        boxes = new List<GameObject>();

        for (int i = 0; i < numberOfBoxesToInstantiate; i++)
        {
            GameObject thisBox = Instantiate(box);
            boxes.Add(thisBox);

        }
    }

    // Update is called once per frame
    void Update() {

    }


    GameObject FindInactiveBox()
    {

        for (int i = 0; i < boxes.Count; i++)
        {

            if (!boxes[i].activeSelf)
            {

                return boxes[i];

            }

        }

        GameObject thisBox = Instantiate(box);
        boxes.Add(thisBox);

        return boxes[boxes.Count-1];

    }

    public void SpawnBox(Vector3 spawnPosition)
    {


        GameObject foundInactiveBox = FindInactiveBox();

        foundInactiveBox.SetActive(true);

        foundInactiveBox.transform.rotation = Quaternion.identity;

        foundInactiveBox.transform.position = spawnPosition;
        Rigidbody inactiveBoxRigidbody = foundInactiveBox.GetComponent<Rigidbody>();

        inactiveBoxRigidbody.AddForce(-inactiveBoxRigidbody.velocity, ForceMode.Impulse);

    }


    public void UnSpawnBoxWithIndex(int index)
    {

        boxes[index].SetActive(false);

    }

    void CycleIndex()
    {

        if (lastActiveIndex >= boxes.Count)
            {

                lastActiveIndex = 0;

            }


    }
}
