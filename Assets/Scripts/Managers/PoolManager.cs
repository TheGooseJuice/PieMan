using System;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

	[Serializable]
	public class ObjectPoolEntry {
		[SerializeField]
		public GameObject m_prefab; 
		
		[SerializeField]
		public int m_count = 3;
	}

	public ObjectPoolEntry[] m_entries;

	[HideInInspector]
	public List<GameObject>[] m_pool;
	protected GameObject m_containerObject;
	public static PoolManager Instance { get { return m_instance; } }
	private static PoolManager m_instance = null; 

	void Awake() {
		if(m_instance != null && m_instance != this) {
			Destroy(this.gameObject);
			return; 
		} else {
			m_instance = this; 
		}
		DontDestroyOnLoad(this.gameObject);
		InitalizePool();
	}

	private void InitalizePool() {
		m_containerObject = gameObject;
		m_containerObject.transform.parent = transform;

		m_pool = new List<GameObject>[m_entries.Length];
		for(int i = 0; i < m_entries.Length; i++ ) {
			ObjectPoolEntry objectPrefab = m_entries[i];

			m_pool[i] = new List<GameObject>();
			for(int n = 0; n < objectPrefab.m_count; n++) {
				GameObject newObj = Instantiate(objectPrefab.m_prefab) as GameObject;
				newObj.name = objectPrefab.m_prefab.name;
				PoolObject(newObj);
			}
		}
	}

	public GameObject GetObjectForType(string objectType, bool onlyPooled) {

		GameObject returnObj = null;
		bool notFound = true;
		int i = 0;
		while((i < m_entries.Length) && (notFound)) {
			GameObject prefab = m_entries[i].m_prefab;
			if (prefab.name == objectType) {
				if(m_pool[i].Count > 0) {
					GameObject pooledObject = m_pool[i][0]; 
					m_pool[i].RemoveAt(0);
					pooledObject.transform.parent = null; 
					pooledObject.SetActive(true);
					returnObj = pooledObject;
					notFound = false;
				}
			}
			if ((!onlyPooled) && (notFound)) {
				GameObject newObj = Instantiate(m_entries[i].m_prefab) as GameObject;
				newObj.name = m_entries[i].m_prefab.name;
				returnObj = newObj;
				notFound = false;
			}
			i++;
		}

		return returnObj; 
	}


	public void PoolObject(GameObject obj) {
		for(int i = 0 ; i < m_entries.Length; i++) {
			if(m_entries[i].m_prefab.name == obj.name) {
				obj.SetActive(false);
				obj.transform.parent = m_containerObject.transform;
				m_pool[i].Add(obj);
				return; //TODO: Clean this up
			}
		}
	}




}
