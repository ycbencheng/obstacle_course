using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison:MonoBehaviour {

  Color originalColor;
  Material material;

  void Start() {
    material = GetComponent<MeshRenderer>().material;
    originalColor = material.color;
  }

  void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Player") {
      material.color = Color.white;

      gameObject.tag = "Hit";
    }
  }

  void OnCollisionExit(Collision other) {
    material.color = originalColor;
  }
}
