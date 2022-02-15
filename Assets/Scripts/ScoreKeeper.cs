using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper:MonoBehaviour {
  int hits = 0;

  void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag != "Hit") {
      hits += 1;
    }
  }
}
