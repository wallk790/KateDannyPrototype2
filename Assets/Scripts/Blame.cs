using UnityEngine;
using System.Collections;

public class Blame : MonoBehaviour {
	
	public SpriteRenderer A;
	public SpriteRenderer B;
	public SpriteRenderer C;
	public SpriteRenderer D;


	void OnTriggerStay2D(Collider2D other){

		if(this.tag == "A"){
			if(Input.GetButtonDown("Select1")){

		if(other.CompareTag("BLAMEA")){
				KeepScore.phase1[0] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMEB")){
				KeepScore.phase1[0] = "b";
				B.enabled = true;
					A.enabled = false;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMEC")){
				KeepScore.phase1[0] = "c";
				C.enabled = true;
					B.enabled = false;
					A.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMED")){
				KeepScore.phase1[0] = "d";
				D.enabled = true;
					B.enabled = false;
					C.enabled = false;
					A.enabled = false;
		}

		if(other.CompareTag("VOTEA")){
				KeepScore.phase2[0] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("VOTEB")){
				KeepScore.phase2[0] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("VOTEC")){
				KeepScore.phase2[0] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
		}

		if(other.CompareTag("VOTED")){
				KeepScore.phase2[0] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
		}
		}
		}

		if(this.tag == "B"){
			if(Input.GetButtonDown("Select2")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[1] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[1] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[1] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[1] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[1] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[1] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[1] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[1] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
			}
		}

		if(this.tag == "C"){
			if(Input.GetButtonDown("Select3")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[2] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[2] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[2] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[2] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[2] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[2] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[2] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[2] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
			}
		}

		if(this.tag == "D"){
			if(Input.GetButtonDown("Select4")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[3] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[3] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[3] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[3] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[3] = "a";
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[3] = "b";
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[3] = "c";
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[3] = "d";
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
			}
		}
	
		
	
		
	




	}

}
