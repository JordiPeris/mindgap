using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public void TestButton() {
        print(References.Instance.testGO.name);
    }
}
