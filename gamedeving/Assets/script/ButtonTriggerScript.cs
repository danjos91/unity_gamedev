using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerScript : MonoBehaviour
{
        public GameObject target;
        public bool isSetActive = false;
        
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.CompareTag("gus"))
            {
                target.SetActive(isSetActive);
            }
        }

}
