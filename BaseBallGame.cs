public class Solution {
    public int CalPoints(string[] operations) {
        for(int i=0;i<operations.Length;i++){
            string j=operations[i];
            string[] score = new string[] {};
        switch(j){
            case "C":
                score.RemoveAt(i-1);
                break;
            case "D":
                for(k=score.Length;k>0;k--){
                  score[i]=score[k] * 2;
                    break;
                }
                break;
            case "+":
                for(k=score.Length;k>0;k--){
                  score[i]=score[k]+score[k-1];
                    break;
                }
                break;
            default:
                score[i]=operations[i];
                break;
                
                
            }
        }
    }
}
