using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper:MonoBehaviour {
  [SerializeField] float waitTime = 3f;

  MeshRenderer renderer;
  Rigidbody rigidbody;

  // Start is called before the first frame update
  void Start() {
    renderer = GetComponent<MeshRenderer>();
    renderer.enabled = false;

    rigidbody = GetComponent<Rigidbody>();
    rigidbody.useGravity = false;
  }

  // Update is called once per frame
  void Update() {
    if (Time.time > waitTime) {
      renderer.enabled = true;
      rigidbody.useGravity = true;
    }
  }
}
