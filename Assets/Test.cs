using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; // 魔法ポイント

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//　MP用の関数
	public void Magic(){
		this.mp -= 5;
		if (mp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
			mp = 0;

		}

	}
}


public class Test : MonoBehaviour {

	void Start () {
		//課題　配列
		int[] array = { 0, 10, 20, 30, 40 };

		Debug.Log (array [0]);
		Debug.Log (array [1]);
		Debug.Log (array [2]);
		Debug.Log (array [3]);
		Debug.Log (array [4]);
		int i;
		for (i = array.Length-1; i >= 0; i--) {

			Debug.Log (array [i]);


		}
		//発展課題

		Boss lastboss = new Boss ();
		//魔法用の関数を11回呼び出す
		int count;
		for (count = 1 ; count <=11 ; count++){
			lastboss.Magic();
			}
	}

	// Update is called once per frame
	void Update () {

	}
}