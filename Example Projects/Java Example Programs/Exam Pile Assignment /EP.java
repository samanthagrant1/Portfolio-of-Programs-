package week09;

import java.util.*;
import java.util.Scanner;

/**
 * Sorts through an pile of exams, and marks them consecutively or delays them.
 * Assignment, COSC241.
 * @author Ksmith, Sgrant.
 */

public class EP implements ExamPile{
    /** To set how many elements are sent to the back of the ArrayList.*/ 
    private static int count = 1;
    /** Specifies how many elements to search through to find the value.*/
    private static int depth = 1;
    /** argValue sets to what is entered on the command line.*/
    private static int argValue =1;
    /** Used to internally store the values from the exam pile. */
    private List<Integer> items = new ArrayList<Integer>();

    /**
     * Initilises the exam pile to hold the values from items internally.
     * @param items - takes input and stores in List of type Integer. 
     */
      
    public void load(List<Integer> items){
        this.items = items;
    }

    /**
     * Returns the number of elements remaining in the ArrayList of items.
     * @return the size of the arrayList.
     */
    public int size(){
        return items.size(); 
    }
        
    /**
     * Peek method returns the value of the element at the top of the ArrayList.
     * If the ArrayList is empty, it will throw an EmptyPileException.
     * @return the value of the item at index 0.
     */
    
    public int peek(){
        if (items.isEmpty()){
            throw new EmptyPileException("Peek on empty stack");
        }else{
            return items.get(0);
        }
    }

    /**
     * Returns the given value from the top section of the pile and removes it.
     * Returns -1 if the value is not found in the specified depth.
     * @param depth - specifies up to which point to look for the value.
     * @param value -  specifies which value should be searched for.
     * @return temp - returns the given value,or -1 if the value does not exist.
     */
    
    public int mark(int depth, int value){
        int temp = 0;
        if (items.isEmpty()){
            throw new EmptyPileException("Mark on empty stack");
        }
        for(int i = 0; i < depth; i++){
            if(items.size()!= 0){
                if(items.get(i) == value){
                    items.remove(items.get(i));
                    i = 0;
                    temp = value;
                    return temp;
                }else{
                    temp = -1;
                }
            }       
        }      
        return temp;   
    }

    /**
     * Moves values from the top of the ArrayList to the bottom.
     * @param count - specifies how many elements to move.
     */
    public void delay(int count){
        if (items.isEmpty()){
            throw new EmptyPileException("Delay on empty stack");
        }
           
        while(count != 0){
            int i = items.get(0);
            items.remove(0);
            items.add(i);
            count--;
        }
    }

    /**
     * Returns a String of D(delay) and M(mark) which represents the steps.
     * @return s - returns the order of steps.
     */
    
    public String sortingSteps(){
        int searchVal = 0;
        String s = "";
        while(items.size() > 0){
            if(items.contains(searchVal)){
                if(mark(depth,searchVal) == -1){
                    s += "D";
                    delay(count);
                }else{
                    s += "M";
                    searchVal++;
                }            
            }else{
                searchVal++;
            }
        }
        return s;
    }

    /**
     * Calls/Sets the input from the command line to the depth and count values.
     * Reads input from System.in.
     * @param args - command line argument.
     */
    public static void main(String[] args){
        if(args.length > 0){
            argValue = Integer.parseInt(args[0]);
  
            if(argValue > 0){
                depth = argValue;
                count = argValue;
            }
        }
        
        EP test = new EP();
        Scanner sc = new Scanner(System.in);
        
        while(sc.hasNextInt()){
            ArrayList<Integer> items = new ArrayList<Integer>();
            String linex = sc.nextLine();
            String[] line = linex.split(" ");
            for(int i = 0; i<= line.length-1; i++){
                int number = Integer.parseInt(line[i]);
                items.add(number);
             
            }
            test.load(items);
            System.out.println(test.sortingSteps());
            items.clear();
        }
    }
}
