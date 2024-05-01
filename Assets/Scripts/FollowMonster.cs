using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMonster : MonoBehaviour
{
    public GameObject cam, monster;

    [SerializeField] private float distanceX, distanceY, disctanceZ;

    void Update()
    {
            cam.transform.position = new Vector3(monster.transform.position.x - distanceX, monster.transform.position.y - distanceY, monster.transform.position.z - disctanceZ);
    }
}
