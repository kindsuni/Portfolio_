using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
    public static Transform[] wayPoints; //적이 이동할 포인트를 담을 배열

    private void Awake()
    {
        wayPoints = new Transform[transform.childCount]; //새로운 배열을 생성. (해당 포인트안의 자식들의 위치정보를 저장하기위해 공간마련)
        for(int i = 0; i<wayPoints.Length; i++)
        {
            wayPoints[i] = transform.GetChild(i); // 실제로 저장.
        }
    }

}
