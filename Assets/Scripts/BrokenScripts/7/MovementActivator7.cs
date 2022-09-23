using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator7 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function name was not spelled properly
    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
    //function name had typo
    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
}
