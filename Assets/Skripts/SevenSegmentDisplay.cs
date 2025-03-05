using System.Collections;
using UnityEngine;

public class SevenSegmentDisplay : MonoBehaviour
{

    public Transform[] segments;
    private readonly int[][] digitMap = new int[][]
    {
        new int[] {1, 1, 1, 1, 1, 1, 0}, // 0
        new int[] {0, 1, 1, 0, 0, 0, 0}, // 1
        new int[] {1, 1, 0, 1, 1, 0, 1}, // 2
        new int[] {1, 1, 1, 1, 0, 0, 1}, // 3
        new int[] {0, 1, 1, 0, 0, 1, 1}, // 4
        new int[] {1, 0, 1, 1, 0, 1, 1}, // 5
        new int[] {1, 0, 1, 1, 1, 1, 1}, // 6
        new int[] {1, 1, 1, 0, 0, 0, 0}, // 7
        new int[] {1, 1, 1, 1, 1, 1, 1}, // 8
        new int[] {1, 1, 1, 1, 0, 1, 1}  // 9
    };
    public void Update()
    {
        for (int i = 0; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()) || Input.GetKeyDown((KeyCode)((int)KeyCode.Keypad0 + i)))
            {
                SetNumber(i);
            }
        }
    }

    public void SetNumber(int number)
    {
        if (number < 0 || number > 9) return;

        for (int i = 0; i < segments.Length; i++)
        {
            bool active = digitMap[number][i] == 1;

            if (i == 0 || i == 3 || i == 6) //waagerechte Segmente
            {
                segments[i].rotation = active ? Quaternion.Euler(0, 0, -90) : Quaternion.Euler(90, 0, 90);
            }
            else //senkrechte Segmente
            {
                segments[i].rotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 90, 0);
            }
        }
    }



    private IEnumerator RotateSegment(Transform segment, bool active, Vector3 axis)
    {
        Quaternion startRotation = segment.rotation;
        Quaternion targetRotation;

        if (axis == Vector3.forward) //obere & untere waagerechte Segmente
        {
            targetRotation = active ? Quaternion.Euler(0, 0, -90) : Quaternion.Euler(0, 0, 90);
        }
        else if (axis == Vector3.right) //mittleres waagerechtes Segment
        {
            targetRotation = active ? Quaternion.Euler(0, 0, -90) : Quaternion.Euler(0, 0, 90);
        }
        else // Vertikale Segmente
        {
            targetRotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 90, 0);
        }

        float time = 0;
        float duration = 1f;

       
        while (time < duration)
        {
            time += Time.deltaTime;
            segment.rotation = Quaternion.Lerp(startRotation, targetRotation, time / duration);
            yield return null;
        }
        segment.rotation = targetRotation;
    }


}