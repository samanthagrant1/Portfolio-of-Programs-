/** Etude 8, Harmonious Pairs
  * find all the harmonious pairs and make sure the lowest number doesnt exceed 200000
  * Student ID: 9493772
  * @author Samantha Grant 
  * */

import java.util.HashMap;
import java.util.*;
import java.util.AbstractCollection;

public class Harmonious{
    
    /** Main method, creates an array that holds the sum of each index num which iworks out 
      * harmonious numbers through comparing
      * @param args, standard input.
      */ 
  
    public static void main(String[] args){
        
        int upper = 2600000;
        int lowestPossible = 0;
        Set <Integer[]> pairs = new LinkedHashSet<Integer[]>(); // doubly linked so can go between pairs 
        int[] sums = new int[upper]; // an array to hold the sums of all factors of the number 
        
        //create an array of all the factors of a number added together
        for(int i = 0; i < sums.length; i ++){
            sums[i] = sumAllFactors(i);
        }
        
        //for each value (i) and corresponding sum of factors in the array
        //compare with the sum at sumAllFactors[i]
        
        for(int i = 0; i < sums.length-1; i++){
           
                if( i < sums[i] && sumAllFactors(sums[i]) == i ){ //check if harmonious 
                    lowestPossible = Math.min(i,sums[i]);
                    //if lowestPossible exceeds 2000000 quit this 
                    if(lowestPossible > 2000000){
                        break;
                    }
                    
                    // adding into the pairs array
                    Integer[] adding = {lowestPossible, Math.max(i,sums[i])};
                    pairs.add(adding);
                }
            }
        
        
        // Print out the linked hash map of pairs
        for(Integer[] pair : pairs){
            System.out.println(pair[0]+" "+pair[1]);
        }
        
       // System.out.println("Number " + pairs.size());
        
    }

    /** sumAllFactors works out the factors of a given number and adds them together.
      * @param num int value to find the factors 
      * @return int summed factors 
      */ 
    
    public static int sumAllFactors(int num){
        int sum = 0;
        int sRoot = (int)Math.sqrt(num);
        
        // i has to start at 2 to divide 
        for(int i = 2; i<= sRoot; i ++){
            if(num%i == 0){ // Diviser!!!
                sum += i;
                // if its not itself 
                if(i != (num/i)){
                  int add = num/i;
                    sum += add;
                }    
            }
        } 
        return sum;
    } 
}



