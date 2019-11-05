using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTile : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other) {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller) {
            controller.ChangeHealth(-1);
        }
    }
}
