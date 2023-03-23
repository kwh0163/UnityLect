using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //private �Ӽ� + �ν����� �ܺο� �����Ű�� ��Ʈ����Ʈ
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
