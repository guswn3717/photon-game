using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterManager : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    void Start()
    {

    }

    public IEnumerator Create()
    {
        while (true)
        {
            photonNetwork.Instantiate("Unit", direction, Quaternion.identity);
            yield return waitForSeconds;
        }
    }

}
