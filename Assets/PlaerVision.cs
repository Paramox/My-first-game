using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerVision : MonoBehaviour
{
    private GameObject _interactableObject; //правило наименования использует <_> обозначает приватную переменную
    public GameObject camera;
    private void OnTriggerEnter(Collider other)
    {
        //if-условный оператор 
        //other это объект который вошел в тригер 
        if (other.TryGetComponent<Item>(out Item item))
        {
            _interactableObject = other.gameObject;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _interactableObject != null)
        {
            _interactableObject.GetComponent<Item>().Interact(camera);
            _interactableObject.GetComponent<Rigidbody>().isKinematic =true;       
        }
    }
}
