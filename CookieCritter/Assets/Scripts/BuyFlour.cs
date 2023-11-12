using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFlour : MonoBehaviour
{
    Animator animator;

    public GameObject flourPilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullLevel() {
        if(GameManager.GetOverallScore() > 0f) {
            animator.SetTrigger("Pull");
            GameManager.DecreaseFromOverallScore(1f);
        }
    }

    public void DispenseFlour() {
        Instantiate(flourPilePrefab, new Vector3(-7.54f, 2.354372f, 0f), Quaternion.identity);
    }
}
