using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 4;
    public float basketBottomY = -14f;
    public float basketSpacingY = 1.5f;
    public List<GameObject> basketList;
    public RoundCounter roundCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject roundCounterGO = GameObject.Find("RoundCounter");
        roundCounter = roundCounterGO.GetComponent<RoundCounter>();
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++) {
            GameObject tbasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tbasketGO.transform.position = pos;
            basketList.Add(tbasketGO);
        }
    }

    public void AppleMissed() {
        // Detroy all of the falling Apples
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tempGO in appleArray) {
            Destroy(tempGO);
        }
        GameObject[] branchArray = GameObject.FindGameObjectsWithTag("Branch");
        foreach (GameObject tempGO in branchArray) {
            Destroy(tempGO);
        }

        // Destroy one of the Baskets
        // Get the index of the last Basket in basketlist
        int basketIndex = basketList.Count - 1;
        // Get a regerence to that Basket GameObject
        GameObject basketGO = basketList[basketIndex];
        // Remove the Basket from the list and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(basketGO);

        // Next Round
        roundCounter.round++;

        // If there are no Baskets left, restart the game
        if (basketList.Count == 0) {
            roundCounter.round = 1;
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
