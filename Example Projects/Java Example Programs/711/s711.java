/**
 * Samantha Grant 
 * s711
 * 
 * 
 **/

import java.util.*;

/**
 * A program that finds values for a, b, c, and d such that a + b + c+ d 
 * is equal to a * b * c * d 
 * **/

public class s711{

  public static void main(String args []){
    

   int a =0 , b= 0, c= 0, d=0;
    

    for (a = 0; a < 711; a++){  
     for ( b = a; b < 711; b++){
        for ( c = b; c < 711; c++){
         
          
         
          d =  711 - a - b - c; 
          
          if((c < d) && (( a + b + c + d) == 711 )&& ((a * b * c * d) == 711000000)){
           
           System.out.println ("$" + a / 100 + "." + a % 100 + " $" + b / 100 + "." + b % 100 + " $" + c / 100 + "." + c % 100 + " $" + d / 100 + "." + d % 100); 
            

      }
    }
   }
    

  }
  }
}