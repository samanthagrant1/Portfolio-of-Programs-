/**
 * Samantha Grant 
 * g711
 * 
 * 
 **/


import java.util.*;

public class g711{
  
  public static ArrayList<Integer> factors = new ArrayList<Integer>();
  public static int a, b, c, d, t, aa, bb, cc;
  public static int count = 0;
  
  /**
   * Main method that loops through the possible solutions and then calls the factors method passing in the current number t.
   * This method also prints out how many solutions there are 
   * **/
  public static void main(String[] args){
    for(t = 0; t < 999; t++){
      factors(t);
    }
    System.out.println(count + " solutions");
  }
  /**
   * findValues is a method that is used to compute the values for a, b, c and d.
   * Values are extracted from the ArrayList and used for values for a, b, c, d 
   * findValues then compares the multiplication and addition of a, b, c, d to see if they add to t
   * @params t - an int value passed in from the main method that is the total value 
   * 
   * **/
  public static void findValues(int t){
    String answer = "";
    
    firstBlock: 
    for(aa = 1; aa < factors.size(); aa++){
      a = factors.get(aa);
      for(bb = aa; bb < factors.size(); bb++){
        b = factors.get(bb);
        for(cc = bb; cc < factors.size(); cc++){
          c = factors.get(cc);
          
          d = c;
          if(a + b + c + d < t){
            d = t - a - b - c;
          }
          
          
          if(((a * b * c * d) == (t*1000000)) && (a+b+c+d == t)){
            if(answer == ""){
              
              answer = "$" + t/100 + "." + String.format("%02d", t%100) + " =" + " $" + a/100 + "." + String.format("%02d", a%100) + " +" + " $" + b/100 + "." + String.format("%02d", b%100) + " +" + " $" + c/100 + "." + String.format("%02d", c%100) + " $" +" + "  + (d/100) + "." + String.format("%02d", d%100);
              count++;
              
            }else{
              answer = "";
              count--;
              break firstBlock;
            }
          }
        }
      }
    }

      if(!answer.equals("")){
        System.out.println(answer);
      }
      factors.clear();
    }
    
      
 /**
  * Factors is a method that works out all factors and then adds them into the factors array 
  * These are the only numbers that are then used in the findValues method to compare the numbers 
  * @param t - an int value that passed in from the main menu, that is the total value 
  * **/
  public static void factors(int t){
    int f = t*1000000;
    for(int i = 1; i <= t; i++){
      if(f % i == 0){
        factors.add(i);
      }
    }
    findValues(t);
  }
  
  
  
}