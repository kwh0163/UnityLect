using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    void QuickFunction(int[] array, int start, int end)
    {
        int pivot = start, left = start + 1, right = end;
        while(left <= right)
        {
            if (array[right] < array[left])
            {
                int tempp = array[right];
                array[right] = array[left];
                array[left] = tempp;
            }
            if (array[left] < array[pivot]) left++;
            if (array[right] > array[pivot]) right--;
        }
        int temp = array[pivot];
        array[pivot] = array[right];
        array[right] = temp;
        
    }
    void Quick(int[] array, int start, int end)
    {
        if (start >= end) return;
        int pivot = start, left = start + 1, right = end;
        while (left <= right)
        {
            while (right > start && array[right] > array[pivot]) right--;
            while (left <= end && array[left] < array[pivot]) left++;
            if (left < right)
            {
                int temp = array[right];
                array[right] = array[left];
                array[left] = temp;
            }
            else if (left == right)
            {
                int temp = array[right];
                array[right] = array[pivot];
                array[pivot] = temp;
            }
            else
            {
                break;
            }
        }
        if (left > right)
        {
            Quick(array, start, right - 1);
            Quick(array, right + 1, end);
        }
        else
        {
            Quick(array, start, left - 1);
            Quick(array, left + 1, end);
        }
    }
    int[] ary = new int[10] {5,3,8,4,9,1,6,2,7,10 };
    private void Start()
    {
        Quick(ary, 0, 9);
        for (int i = 0; i < 10; i++) Debug.Log(ary[i]);
    }
}
