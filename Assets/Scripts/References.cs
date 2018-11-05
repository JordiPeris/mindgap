using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour {

    public static References Instance;

    public GameObject testGO;

    private void Awake() {
        Instance = this;
    }

}
