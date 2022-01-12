using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    void Update()
    {
		
		switch (GameManager.Instance.GameState)
        {
            case GameState.Playing:
                transform.Rotate(Vector3.right, 150f * Time.deltaTime);

                break;
            case GameState.Dead:
					transform.Rotate(Vector3.right, 0f * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
