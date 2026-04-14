using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact() {
        Debug.Log("Interact!");
        Transform kitchenObject = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObject.localPosition = Vector3.zero;
    }
}
