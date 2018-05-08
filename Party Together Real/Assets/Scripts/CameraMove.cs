using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove: MonoBehaviour {

    public Transform pl;

	void Update () {
        transform.position = new Vector3(pl.position.x, pl.position.y + 1.5f, pl.position.z + 2);
    }
}
