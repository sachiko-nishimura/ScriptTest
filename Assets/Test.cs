using UnityEngine;
using System.Collections;

public class Boss {        
	private int mp = 53;          // マジックポイント(mpを53で初期化する)

	// 魔法攻撃の関数
	public  void Magic(int magic) { 
		
		// 残りmpを減らす
		this.mp -= magic;

		if (mp >= magic) {
			// mpが53以上だった場合
			Debug.Log ("魔法攻撃をした。残りMPは"+ this.mp +"。");
			// 残りmpを減らす
			this.mp -= magic;
		} else {
			// mpが5未満だった場合
			Debug.Log("MPが足りないため魔法が使えない。");
		}


	}

}

public class Test : MonoBehaviour {

	void Start () {

		// 配列を初期化する
		int[] array = {30, 20, 50, 10, 80};

		// 5回処理を繰り返す
		for (int i = 0; i <= 4; i++) {
			Debug.Log (array [i]);
		}
			
		// 5回処理を繰り返す
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
		}
			

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 魔法攻撃を10回繰り返す
		for (int i = 1; i <= 10; i++) {

		// 魔法攻撃の関数を呼び出す
		lastboss.Magic(5);

		}
	}

	// Update is called once per frame
	void Update () {

	}
}