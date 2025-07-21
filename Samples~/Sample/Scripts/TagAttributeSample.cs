using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagAttributeSample : MonoBehaviour
{
	[SerializeField, Tag]
	private string tagName;

	[SerializeField, Tag]
    private List<string> tagNameList;
}
