using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Fix : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LateStart());
    }

    IEnumerator LateStart() {
        yield return new WaitForSeconds(Mathf.Epsilon);
        PlayerMechanics.Instance.unlockedTimeTraversal = true;
        PlayerMechanics.Instance.unlockedDoubleJump = true;
        PlayerMechanics.Instance.unlockedDash = true;
        PlayerMechanics.Instance.unlockedAttack = true;
        PlayerMechanics.Instance.unlockedWallClimb = true;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
