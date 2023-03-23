using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //private 속성 + 인스펙터 외부에 노출시키는 어트리뷰트
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource effectSource;
    public void Start()
    {
        audioSource.volume = 0;
    }
    public void SoundCall(int count)
    {
        audioSource.PlayOneShot(audioClip[count]);
    }
    public void Volume(float volume)
    {
        audioSource.volume = volume;
    }

}
