using System.Collections;
using UnityEngine;

public class ActiivateBoundingBox : MonoBehaviour {

    void Update() {
            StartCoroutine(DelayBounds());
    }



    IEnumerator DelayBounds() {
        yield return new WaitForEndOfFrame();
        foreach (BoundingBox bounds in FindObjectsOfType<BoundingBox>()) {
            bounds.UpdateBounds();
        }
    }
}
